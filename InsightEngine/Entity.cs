using InsightEngine.Contract;
using System.Collections.Generic;

namespace InsightEngine
{
    public class Entity
    {
        public Transform Transform { get; set; }
        public Scene Scene { get; set; }

        List<Component> components { get; set; }

        public Entity()
        {
            Transform = new Transform();
            components = new List<Component>();
        }


        public void AddComponent(Component component)
        {
            components.Add(component);
            component.SetEntity(this);
        }

        public Component GetComponent<T>()
            where T : Component
        {
            foreach (var component in components)
            {
                if (component is T)
                    return component;
            }

            return null;
        }

        public virtual void Start()
        {
            foreach (var component in components)
            {
                component.Start();
            }
        }

        public virtual void Update()
        {
            foreach (var component in components)
            {
                component.Update();
            }
        }
    }
}
