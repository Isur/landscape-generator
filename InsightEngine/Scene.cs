using InsightEngine.Components;
using InsightEngine.Components.Renderers;
using InsightEngine.Input;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace InsightEngine
{
    public class Scene
    {
        List<Entity> entities { get; }
        List<Entity> entitiesToAdd { get; }
        public Device Device { get; set; }

        public Scene(Control control)
        {
            entities = new List<Entity>();
            entitiesToAdd = new List<Entity>();

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

            Device.RenderState.Lighting = false;
            Device.RenderState.CullMode = Cull.None; //sets which site of the triangles should be shown
            Device.RenderState.FillMode = FillMode.Solid; //this sets the mode so we can actually see the triangle construct of the terrain
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

            if (entitiesToAdd.Count > 0)
            {
                entities.AddRange(entitiesToAdd);
                entitiesToAdd.Clear();
            }

            Device.EndScene();
            Device.Present();

            Keyboard.Reset();
            Mouse.Reset();
        }

        public void Instantiate(Entity entity)
        {
            entitiesToAdd.Add(entity);
            entity.Scene = this;
            entity.Start();
        }

        public void Save(string file)
        {
            var toSave = GetContentToSave();
            SaveContent(file, toSave);
        }

        private string GetContentToSave()
        {
            var terrainSavable = "";
            var modelsSavable = new StringBuilder();
            modelsSavable.Append("[");

            foreach (var entity in entities)
            {
                var terrain = entity.GetComponent<TerrainGenerator>();
                if (terrain != null)
                    terrainSavable += terrain.ToSavable();

                var model = entity.GetComponent<ShapeRenderer>();
                if (model != null)
                    modelsSavable.Append(model.ToSavable());
            }

            modelsSavable.Append("]");

            var toSave = terrainSavable +
                Environment.NewLine +
                modelsSavable.ToString();

            return toSave;
        }

        private void SaveContent(string file, string content)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.WriteLine(content);
            }
        }
    }
}
