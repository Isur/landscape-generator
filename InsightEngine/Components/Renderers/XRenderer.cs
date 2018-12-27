using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;

namespace InsightEngine.Components.Renderers
{
    public class XRenderer : ShapeRenderer
    {
        Texture[] textures;
        Material[] materials;
        float spacemeshradius;


        public string Filename { get; set; }

        public override void Start()
        {
            LoadMesh(Filename, ref mesh,
                ref materials, ref textures, ref spacemeshradius);
        }

        protected override int numberVerts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void GeneratePoints(GraphicsStream data)
        {
            throw new NotImplementedException();
        }

        protected override void SetIndices(List<short> indices)
        {
            throw new NotImplementedException();
        }
    }
}
