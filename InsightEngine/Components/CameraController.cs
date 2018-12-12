using InsightEngine.Contract;
using InsightEngine.Input;
using Microsoft.DirectX;
using System;

namespace InsightEngine.Components
{
    public class CameraController : Component
    {
        public float MoveSpeed { get; set; } = 5f;
        public double RotationSpeed { get; set; } = 0.02f;

        float speed;

        Vector3 camPosition;
        float rotXZ;
        float rotY = 0;
        Vector3 camUp;
        Vector3 camLookAt = new Vector3();


        public override void Start()
        {
            camPosition = new Vector3(Transform.Position.X, Transform.Position.Y, Transform.Position.Z);
            rotXZ = -0.8f;
            camUp = new Vector3(0, 1, 0);

            camLookAt.X = (float)Math.Sin(rotY) + camPosition.X + (float)(Math.Sin(rotXZ) * Math.Sin(rotY));    //      
            camLookAt.Y = (float)Math.Sin(rotXZ) + camPosition.Y;  // Bind the camera lookAt somehow with the camera position, so once we move around we also move the lookAt
            camLookAt.Z = (float)Math.Cos(rotY) + camPosition.Z + (float)(Math.Sin(rotXZ) * Math.Cos(rotY));  //

            device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, device.Viewport.Width / device.Viewport.Height, 1.0f, 1000.0f);  //sets the perspective and the field of view of the camer
            device.Transform.View = Matrix.LookAtLH(camPosition, camLookAt, camUp); //sets the position, the lookat and the up vector of the camera
        }

        public override void Update()
        {
            Movement();

            Transform.Position = new Vector3(
                Transform.Position.X + speed * (float)Math.Sin(rotY),
                Transform.Position.Y + speed * (float)Math.Sin(rotXZ),
                Transform.Position.Z + speed * (float)Math.Cos(rotY));

            //camPosition = new Vector3(Transform.Position.X, Transform.Position.Y, Transform.Position.Z);

            //rotY += 0.1f;
            camUp = new Vector3(0, 1, 0);

            //rotY += 0.01f * Mouse.DeltaX;
            //rotXZ -= 0.01f * Mouse.DeltaY;

            Transform.Rotation = new Vector3(
                (float)Math.Sin(rotY) + Transform.Position.X + (float)(Math.Sin(rotXZ) * Math.Sin(rotY)),  //      
                (float)Math.Sin(rotXZ) + Transform.Position.Y,  // Bind the camera lookAt somehow with the camera position, so once we move around we also move the lookAt
                (float)Math.Cos(rotY) + Transform.Position.Z + (float)(Math.Sin(rotXZ) * Math.Cos(rotY)));  //

            device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, device.Viewport.Width / device.Viewport.Height, 1.0f, 10000.0f);  //sets the perspective and the field of view of the camer
            device.Transform.View = Matrix.LookAtLH(Transform.Position, Transform.Rotation, camUp);
        }

        private void Movement()
        {
            if (Keyboard.W)
                speed = MoveSpeed;
            else if (Keyboard.S)
                speed = -MoveSpeed;
            else
                speed = 0;

            if (Mouse.Click)
            {
                if (Mouse.DeltaX < 0)
                    rotY -= 0.02f;
                else if (Mouse.DeltaX > 0)
                    rotY += 0.02f;

                if (Mouse.DeltaY < 0)
                    if (rotXZ < Math.PI / 2)
                        rotXZ += 0.02f;

                if (Mouse.DeltaY > 0)
                    if (rotXZ > -Math.PI / 2)
                        rotXZ -= 0.02f;
            }
        }
    }
}
