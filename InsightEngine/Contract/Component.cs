using Microsoft.DirectX.Direct3D;

namespace InsightEngine.Contract
{
    public abstract class Component
    {
        protected Entity entity { get; set; }
        protected Device device
        {
            get { return entity.Scene.Device; }
        }
        public Transform Transform
        {
            get { return entity.Transform; }
            set { entity.Transform = value; }
        }


        public Component()
        {

        }


        public virtual void Start() { }
        public virtual void Update() { }

        public void SetEntity(Entity entity)
        {
            this.entity = entity;
        }

        public T GetComponent<T>()
            where T : Component
        {
            return entity.GetComponent<T>() as T;
        }
        public void Instantiate(Entity entity)
        {
            this.entity.Scene.Instantiate(entity);
        }
    }
}
