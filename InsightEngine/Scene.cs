using InsightEngine.Input;
using Microsoft.DirectX.Direct3D;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InsightEngine
{
    public class Scene
    {
        List<Entity> entities { get; set; }
        public Device Device { get; set; }

        public Scene(Control control)
        {
            entities = new List<Entity>();

            SetupDevice(control);
        }


        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
            entity.Scene = this;
        }

        public void Start()
        {
            foreach (var entity in entities)
            {
                entity.Start();
            }
        }

        private void SetupDevice(Control control)
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard; //just how the stuff should be moved from the backbuffer to the front buffer
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D16;

            Device = new Device(0, DeviceType.Hardware, control, CreateFlags.HardwareVertexProcessing, pp);
        }

        public void Update()
        {
            Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Black, 1, 0);
            Device.BeginScene();
            Device.VertexFormat = CustomVertex.PositionColored.Format;

            foreach (var entity in entities)
            {
                entity.Update();
            }

            Device.EndScene();
            Device.Present();

            Keyboard.Reset();
            Mouse.Reset();
        }
    }
}
