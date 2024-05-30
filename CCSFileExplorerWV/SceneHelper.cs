using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform;

namespace CCSFileExplorerWV
{
	// Token: 0x02000012 RID: 18
	public static class SceneHelper
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000040E4 File Offset: 0x000022E4
		public static void InitializeDevice(Control c)
		{
			SceneHelper.ctrl = c;
			SceneHelper.winfo = Utilities.CreateWindowsWindowInfo(c.Handle);
			SceneHelper.context = new GraphicsContext(GraphicsMode.Default, SceneHelper.winfo);
			SceneHelper.context.MakeCurrent(SceneHelper.winfo);
			SceneHelper.init = true;
			SceneHelper.context.LoadAll();
			GL.ClearColor(0.1f, 0.2f, 0.5f, 0f);
			GL.Enable(EnableCap.DepthTest);
			GL.CullFace(CullFaceMode.FrontAndBack);
			SceneHelper.Resize();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000416C File Offset: 0x0000236C
		public static void Resize()
		{
			GL.Viewport(0, 0, SceneHelper.ctrl.Width, SceneHelper.ctrl.Height);
			Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(0.7853982f, (float)SceneHelper.ctrl.Width / (float)SceneHelper.ctrl.Height, 1f, 100000f);
			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadMatrix(ref projection);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000041D4 File Offset: 0x000023D4
		public static void InitScene(List<float[]> triangles)
		{
			List<SceneHelper.Vertex> result = new List<SceneHelper.Vertex>();
			float maxz;
			float maxy;
			float maxx;
			float minz;
			float minx;
			float miny = minx = (minz = (maxx = (maxy = (maxz = 0f))));
			foreach (float[] v in triangles)
			{
				result.Add(new SceneHelper.Vertex(v[0], v[2], v[1], v[3], v[4]));
				if (v[0] < minx)
				{
					minx = v[0];
				}
				if (v[0] > maxx)
				{
					maxx = v[0];
				}
				if (v[2] < miny)
				{
					miny = v[2];
				}
				if (v[2] > maxy)
				{
					maxy = v[2];
				}
				if (v[1] < minz)
				{
					minz = v[1];
				}
				if (v[1] > maxz)
				{
					maxz = v[1];
				}
			}
			SceneHelper.camDist = (float)Math.Sqrt((double)((maxx - minx) * (maxx - minx) + (maxy - miny) * (maxy - miny) + (maxz - minz) * (maxz - minz)));
			SceneHelper.camDist *= 1.5f;
			SceneHelper.camDist += 1f;
			SceneHelper.camHeight = SceneHelper.camDist;
			float dx = -(minx + maxx) / 2f;
			float dy = -(miny + maxy) / 2f;
			float dz = -(minz + maxz) / 2f;
			for (int i = 0; i < result.Count; i++)
			{
				SceneHelper.Vertex tmp = result[i];
				tmp.X += dx;
				tmp.Y += dy;
				tmp.Z += dz;
				result[i] = tmp;
			}
			SceneHelper.vertices = result.ToArray();
			SceneHelper.SetRotation360(0f);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004394 File Offset: 0x00002594
		public static void SetRotation360(float r)
		{
			SceneHelper.rotation = Matrix4.CreateRotationY(r * 0.017452778f);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000043A7 File Offset: 0x000025A7
		public static void SetHeight(float h)
		{
			SceneHelper.camHeight = SceneHelper.camDist * h;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000043B5 File Offset: 0x000025B5
		public static void SetZoomFactor(float f)
		{
			if (f <= 0.01f)
			{
				f = 0.01f;
			}
			if (f > 3f)
			{
				f = 3f;
			}
			SceneHelper.zoomF = f;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000043DC File Offset: 0x000025DC
		public static void Render()
		{
			if (SceneHelper.wireframe)
			{
				GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
			}
			else
			{
				GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
			}
			GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);
			Matrix4 cam = Matrix4.LookAt(new Vector3(0f, SceneHelper.camHeight, -SceneHelper.camDist * SceneHelper.zoomF), Vector3.Zero, Vector3.UnitY);
			Matrix4 model = SceneHelper.rotation * cam;
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadMatrix(ref model);
			GL.Begin(BeginMode.Triangles);
			for (int i = 0; i < SceneHelper.vertices.Length / 3; i++)
			{
				SceneHelper.Vertex v = SceneHelper.vertices[i * 3];
				SceneHelper.Vertex v2 = SceneHelper.vertices[i * 3 + 1];
				SceneHelper.Vertex v3 = SceneHelper.vertices[i * 3 + 2];
				GL.Color3(1f, 1f, 0f);
				GL.Vertex3(v.X, v.Y, v.Z);
				GL.Color3(1f, 0f, 0f);
				GL.Vertex3(v2.X, v2.Y, v2.Z);
				GL.Color3(0.2f, 0.9f, 1f);
				GL.Vertex3(v3.X, v3.Y, v3.Z);
			}
			GL.End();
			SceneHelper.context.SwapBuffers();
		}

		// Token: 0x04000030 RID: 48
		public static Control ctrl;

		// Token: 0x04000031 RID: 49
		public static bool init = false;

		// Token: 0x04000032 RID: 50
		public static IGraphicsContext context;

		// Token: 0x04000033 RID: 51
		public static IWindowInfo winfo;

		// Token: 0x04000034 RID: 52
		public static float camDist = 30f;

		// Token: 0x04000035 RID: 53
		public static float camHeight = 30f;

		// Token: 0x04000036 RID: 54
		public static float zoomF = 1f;

		// Token: 0x04000037 RID: 55
		public static Matrix4 rotation;

		// Token: 0x04000038 RID: 56
		public static bool doRotate = true;

		// Token: 0x04000039 RID: 57
		public static bool wireframe = false;

		// Token: 0x0400003A RID: 58
		public static SceneHelper.Vertex[] vertices = new SceneHelper.Vertex[0];

		// Token: 0x02000040 RID: 64
		public class Vertex
		{
			// Token: 0x06000120 RID: 288 RVA: 0x0000C0FD File Offset: 0x0000A2FD
			public Vertex(float x, float y, float z, float u, float v)
			{
				this.X = x;
				this.Y = y;
				this.Z = z;
				this.U = u;
				this.V = v;
			}

			// Token: 0x040000E0 RID: 224
			public float X;

			// Token: 0x040000E1 RID: 225
			public float Y;

			// Token: 0x040000E2 RID: 226
			public float Z;

			// Token: 0x040000E3 RID: 227
			public float U;

			// Token: 0x040000E4 RID: 228
			public float V;
		}
	}
}
