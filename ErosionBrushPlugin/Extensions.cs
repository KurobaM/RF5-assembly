using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000947")]
	public static class Extensions
	{
		// Token: 0x06005E88 RID: 24200 RVA: 0x0001F650 File Offset: 0x0001D850
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x2C278D0", Offset = "0x2C279D1", VA = "0x2C278D0")]
		public static bool InRange(this Rect rect, Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0001F668 File Offset: 0x0001D868
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x2C279D0", Offset = "0x2C27AD1", VA = "0x2C279D0")]
		public static Vector3 ToDir(this float angle)
		{
			return default(Vector3);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0001F680 File Offset: 0x0001D880
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x2C27A90", Offset = "0x2C27B91", VA = "0x2C27A90")]
		public static float ToAngle(this Vector3 dir)
		{
			return 0f;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0001F698 File Offset: 0x0001D898
		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x2C27B20", Offset = "0x2C27C21", VA = "0x2C27B20")]
		public static Vector3 V3(this Vector2 v2)
		{
			return default(Vector3);
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x2C27B60", Offset = "0x2C27C61", VA = "0x2C27B60")]
		public static Vector2 V2(this Vector3 v3)
		{
			return default(Vector2);
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x2C27B90", Offset = "0x2C27C91", VA = "0x2C27B90")]
		public static Vector3 ToV3(this float f)
		{
			return default(Vector3);
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x2C27BD0", Offset = "0x2C27CD1", VA = "0x2C27BD0")]
		public static Quaternion EulerToQuat(this Vector3 v)
		{
			return default(Quaternion);
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x2C27C90", Offset = "0x2C27D91", VA = "0x2C27C90")]
		public static Quaternion EulerToQuat(this float f)
		{
			return default(Quaternion);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0001F710 File Offset: 0x0001D910
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x2C27D50", Offset = "0x2C27E51", VA = "0x2C27D50")]
		public static Vector3 Direction(this float angle)
		{
			return default(Vector3);
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0001F728 File Offset: 0x0001D928
		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x2C27E10", Offset = "0x2C27F11", VA = "0x2C27E10")]
		public static float Angle(this Vector3 dir)
		{
			return 0f;
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0001F740 File Offset: 0x0001D940
		[Token(Token = "0x6004E53")]
		[Address(RVA = "0x2C27EA0", Offset = "0x2C27FA1", VA = "0x2C27EA0")]
		public static Rect Clamp(this Rect r, float p)
		{
			return default(Rect);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0001F758 File Offset: 0x0001D958
		[Token(Token = "0x6004E54")]
		[Address(RVA = "0x2C27F40", Offset = "0x2C28041", VA = "0x2C27F40")]
		public static Rect ClampFromLeft(this Rect r, float p)
		{
			return default(Rect);
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x0001F770 File Offset: 0x0001D970
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x2C28000", Offset = "0x2C28101", VA = "0x2C28000")]
		public static Rect Clamp(this Rect r, int p)
		{
			return default(Rect);
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0001F788 File Offset: 0x0001D988
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x2C28090", Offset = "0x2C28191", VA = "0x2C28090")]
		public static Rect ClampFromLeft(this Rect r, int p)
		{
			return default(Rect);
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x2C28140", Offset = "0x2C28241", VA = "0x2C28140")]
		public static bool Intersects(this Rect r1, Rect r2)
		{
			return default(bool);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
		[Token(Token = "0x6004E58")]
		[Address(RVA = "0x2C281F0", Offset = "0x2C282F1", VA = "0x2C281F0")]
		public static bool Intersects(this Rect r1, Rect[] rects)
		{
			return default(bool);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x2C282A0", Offset = "0x2C283A1", VA = "0x2C282A0")]
		public static bool Contains(this Rect r1, Rect r2)
		{
			return default(bool);
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[Token(Token = "0x6004E5A")]
		[Address(RVA = "0x2C28360", Offset = "0x2C28461", VA = "0x2C28360")]
		public static Rect Extend(this Rect r, float f)
		{
			return default(Rect);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x0001F800 File Offset: 0x0001DA00
		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x2C28400", Offset = "0x2C28501", VA = "0x2C28400")]
		public static Coord RoundToCoord(this Vector2 pos)
		{
			return default(Coord);
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x0001F818 File Offset: 0x0001DA18
		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x2C28460", Offset = "0x2C28561", VA = "0x2C28460")]
		public static Coord FloorToCoord(this Vector3 pos, float cellSize)
		{
			return default(Coord);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x0001F830 File Offset: 0x0001DA30
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x2C28520", Offset = "0x2C28621", VA = "0x2C28520")]
		public static Coord CeilToCoord(this Vector3 pos, float cellSize)
		{
			return default(Coord);
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0001F848 File Offset: 0x0001DA48
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x2C285E0", Offset = "0x2C286E1", VA = "0x2C285E0")]
		public static Coord RoundToCoord(this Vector3 pos, float cellSize)
		{
			return default(Coord);
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x0001F860 File Offset: 0x0001DA60
		[Token(Token = "0x6004E5F")]
		[Address(RVA = "0x2C246C0", Offset = "0x2C247C1", VA = "0x2C246C0")]
		public static CoordRect ToCoordRect(this Vector3 pos, float range, float cellSize)
		{
			return default(CoordRect);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x0001F878 File Offset: 0x0001DA78
		[Token(Token = "0x6004E60")]
		[Address(RVA = "0x2C24050", Offset = "0x2C24151", VA = "0x2C24050")]
		public static CoordRect ToCoordRect(this Vector3 pos, float range, float cellSizeX, float cellSizeZ)
		{
			return default(CoordRect);
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x0001F890 File Offset: 0x0001DA90
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x2C25030", Offset = "0x2C25131", VA = "0x2C25030")]
		public static CoordRect GetHeightRect(this Terrain terrain)
		{
			return default(CoordRect);
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x2C251D0", Offset = "0x2C252D1", VA = "0x2C251D0")]
		public static CoordRect GetSplatRect(this Terrain terrain)
		{
			return default(CoordRect);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E63")]
		[Address(RVA = "0x2C275F0", Offset = "0x2C276F1", VA = "0x2C275F0")]
		public static float[,] SafeGetHeights(this TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ)
		{
			return null;
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E64")]
		[Address(RVA = "0x2C27680", Offset = "0x2C27781", VA = "0x2C27680")]
		public static float[,,] SafeGetAlphamaps(this TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ)
		{
			return null;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E65")]
		[Address(RVA = "0x2C286A0", Offset = "0x2C287A1", VA = "0x2C286A0")]
		public static List<Type> GetAllChildTypes(this Type type)
		{
			return null;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E66")]
		[Address(RVA = "0x2C28820", Offset = "0x2C28921", VA = "0x2C28820")]
		public static Texture2D ColorTexture(int width, int height, Color color)
		{
			return null;
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		[Token(Token = "0x6004E67")]
		[Address(RVA = "0x2C28950", Offset = "0x2C28A51", VA = "0x2C28950")]
		public static bool Equal(Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0x2C28A60", Offset = "0x2C28B61", VA = "0x2C28A60")]
		public static bool Equal(Ray r1, Ray r2)
		{
			return default(bool);
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0x2C28B30", Offset = "0x2C28C31", VA = "0x2C28B30")]
		public static void RemoveChildren(this Transform tfm)
		{
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6A")]
		[Address(RVA = "0x2C28BF0", Offset = "0x2C28CF1", VA = "0x2C28BF0")]
		public static Transform FindChildRecursive(this Transform tfm, string name)
		{
			return null;
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6B")]
		[Address(RVA = "0x2C28D30", Offset = "0x2C28E31", VA = "0x2C28D30")]
		public static void ToggleDisplayWireframe(this Transform tfm, bool show)
		{
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
		[Token(Token = "0x6004E6C")]
		[Address(RVA = "0x2C28D40", Offset = "0x2C28E41", VA = "0x2C28D40")]
		public static int ToInt(this Coord coord)
		{
			return 0;
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0001F908 File Offset: 0x0001DB08
		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x2C28D80", Offset = "0x2C28E81", VA = "0x2C28D80")]
		public static Coord ToCoord(this int hash)
		{
			return default(Coord);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6E")]
		public static void CheckAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = true)
		{
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6F")]
		public static void CheckRemove<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
		{
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E70")]
		public static TValue CheckGet<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
		{
			return null;
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E71")]
		public static void CheckAdd<T>(this HashSet<T> set, T obj)
		{
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E72")]
		public static void CheckRemove<T>(this HashSet<T> set, T obj)
		{
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E73")]
		public static void SetState<T>(this HashSet<T> set, T obj, bool state)
		{
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E74")]
		[Address(RVA = "0x2C28E10", Offset = "0x2C28F11", VA = "0x2C28E10")]
		public static void Normalize(this float[,,] array, int pinnedLayer)
		{
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E75")]
		[Address(RVA = "0x2C29020", Offset = "0x2C29121", VA = "0x2C29020")]
		public static void DrawDebug(this Vector3 pos, float range = 1f, [Optional] Color color)
		{
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E76")]
		[Address(RVA = "0x2C294F0", Offset = "0x2C295F1", VA = "0x2C294F0")]
		public static void DrawDebug(this Rect rect, [Optional] Color color)
		{
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E77")]
		[Address(RVA = "0x2C298D0", Offset = "0x2C299D1", VA = "0x2C298D0")]
		public static void Resize(this Terrain terrain, int resolution, Vector3 size)
		{
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E78")]
		[Address(RVA = "0x2C29B10", Offset = "0x2C29C11", VA = "0x2C29B10")]
		public static Transform AddChild(this Transform tfm, string name = "", [Optional] Vector3 offset)
		{
			return null;
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x2C29C00", Offset = "0x2C29D01", VA = "0x2C29C00")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC1E0", Offset = "0x1AC2E1")]
		public static IEnumerable<Vector3> CircleAround(this Vector3 center, float radius, int numPoints, bool endWhereStart = false)
		{
			return null;
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x0001F920 File Offset: 0x0001DB20
		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0x2C29D10", Offset = "0x2C29E11", VA = "0x2C29D10")]
		public static float EvaluateMultithreaded(this AnimationCurve curve, float time)
		{
			return 0f;
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7B")]
		public static void GetPropertiesFrom<T1, T2>(this T1 dst, T2 src) where T1 : class where T2 : class
		{
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x2C2A0B0", Offset = "0x2C2A1B1", VA = "0x2C2A0B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC280", Offset = "0x1AC381")]
		public static IEnumerable<FieldInfo> UsableFields(this Type type, bool nonPublic = false)
		{
			return null;
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x2C2A190", Offset = "0x2C2A291", VA = "0x2C2A190")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC300", Offset = "0x1AC401")]
		public static IEnumerable<PropertyInfo> UsableProperties(this Type type, bool nonPublic = false, bool skipItems = true)
		{
			return null;
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x2C2A280", Offset = "0x2C2A381", VA = "0x2C2A280")]
		public static Component CopyComponent(Component src, GameObject go)
		{
			return null;
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7F")]
		public static void ReflectionReset<T>(this T obj)
		{
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E80")]
		public static T ReflectionCopy<T>(this T obj)
		{
			return null;
		}

		// Token: 0x02000E29 RID: 3625
		[Token(Token = "0x200144D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159870", Offset = "0x159971")]
		private sealed class <CircleAround>d__48 : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
		{
			// Token: 0x06005EC0 RID: 24256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AEE")]
			[Address(RVA = "0x2C29CD0", Offset = "0x2C29DD1", VA = "0x2C29CD0")]
			[DebuggerHidden]
			public <CircleAround>d__48(int <>1__state)
			{
			}

			// Token: 0x06005EC1 RID: 24257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AEF")]
			[Address(RVA = "0x2C2A9A0", Offset = "0x2C2AAA1", VA = "0x2C2A9A0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005EC2 RID: 24258 RVA: 0x0001F938 File Offset: 0x0001DB38
			[Token(Token = "0x6007AF0")]
			[Address(RVA = "0x2C2A9B0", Offset = "0x2C2AAB1", VA = "0x2C2A9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x0001F950 File Offset: 0x0001DB50
			[Token(Token = "0x17000E66")]
			private Vector3 Current
			{
				[Token(Token = "0x6007AF1")]
				[Address(RVA = "0x2C2AB70", Offset = "0x2C2AC71", VA = "0x2C2AB70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06005EC4 RID: 24260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AF2")]
			[Address(RVA = "0x2C2AB80", Offset = "0x2C2AC81", VA = "0x2C2AB80", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E67")]
			private object Current
			{
				[Token(Token = "0x6007AF3")]
				[Address(RVA = "0x2C2ABE0", Offset = "0x2C2ACE1", VA = "0x2C2ABE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005EC6 RID: 24262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AF4")]
			[Address(RVA = "0x2C2AC50", Offset = "0x2C2AD51", VA = "0x2C2AC50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Vector3> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005EC7 RID: 24263 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AF5")]
			[Address(RVA = "0x2C2AD20", Offset = "0x2C2AE21", VA = "0x2C2AD20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BE69 RID: 48745
			[Token(Token = "0x401BBCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BE6A RID: 48746
			[Token(Token = "0x401BBCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Vector3 <>2__current;

			// Token: 0x0400BE6B RID: 48747
			[Token(Token = "0x401BBD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400BE6C RID: 48748
			[Token(Token = "0x401BBD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int numPoints;

			// Token: 0x0400BE6D RID: 48749
			[Token(Token = "0x401BBD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int <>3__numPoints;

			// Token: 0x0400BE6E RID: 48750
			[Token(Token = "0x401BBD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool endWhereStart;

			// Token: 0x0400BE6F RID: 48751
			[Token(Token = "0x401BBD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool <>3__endWhereStart;

			// Token: 0x0400BE70 RID: 48752
			[Token(Token = "0x401BBD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 center;

			// Token: 0x0400BE71 RID: 48753
			[Token(Token = "0x401BBD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 <>3__center;

			// Token: 0x0400BE72 RID: 48754
			[Token(Token = "0x401BBD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float radius;

			// Token: 0x0400BE73 RID: 48755
			[Token(Token = "0x401BBD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float <>3__radius;

			// Token: 0x0400BE74 RID: 48756
			[Token(Token = "0x401BBD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <radianStep>5__2;

			// Token: 0x0400BE75 RID: 48757
			[Token(Token = "0x401BBDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int <i>5__3;
		}

		// Token: 0x02000E2A RID: 3626
		[Token(Token = "0x200144E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159880", Offset = "0x159981")]
		private sealed class <UsableFields>d__51 : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
		{
			// Token: 0x06005EC8 RID: 24264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AF6")]
			[Address(RVA = "0x2C2A150", Offset = "0x2C2A251", VA = "0x2C2A150")]
			[DebuggerHidden]
			public <UsableFields>d__51(int <>1__state)
			{
			}

			// Token: 0x06005EC9 RID: 24265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AF7")]
			[Address(RVA = "0x2C2AD30", Offset = "0x2C2AE31", VA = "0x2C2AD30", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005ECA RID: 24266 RVA: 0x0001F968 File Offset: 0x0001DB68
			[Token(Token = "0x6007AF8")]
			[Address(RVA = "0x2C2AD40", Offset = "0x2C2AE41", VA = "0x2C2AD40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x06005ECB RID: 24267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E68")]
			private FieldInfo Current
			{
				[Token(Token = "0x6007AF9")]
				[Address(RVA = "0x2C2AE80", Offset = "0x2C2AF81", VA = "0x2C2AE80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ECC RID: 24268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFA")]
			[Address(RVA = "0x2C2AE90", Offset = "0x2C2AF91", VA = "0x2C2AE90", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x06005ECD RID: 24269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E69")]
			private object Current
			{
				[Token(Token = "0x6007AFB")]
				[Address(RVA = "0x2C2AEF0", Offset = "0x2C2AFF1", VA = "0x2C2AEF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ECE RID: 24270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AFC")]
			[Address(RVA = "0x2C2AF00", Offset = "0x2C2B001", VA = "0x2C2AF00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FieldInfo> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005ECF RID: 24271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AFD")]
			[Address(RVA = "0x2C2AFC0", Offset = "0x2C2B0C1", VA = "0x2C2AFC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BE76 RID: 48758
			[Token(Token = "0x401BBDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BE77 RID: 48759
			[Token(Token = "0x401BBDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private FieldInfo <>2__current;

			// Token: 0x0400BE78 RID: 48760
			[Token(Token = "0x401BBDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400BE79 RID: 48761
			[Token(Token = "0x401BBDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool nonPublic;

			// Token: 0x0400BE7A RID: 48762
			[Token(Token = "0x401BBDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool <>3__nonPublic;

			// Token: 0x0400BE7B RID: 48763
			[Token(Token = "0x401BBE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type type;

			// Token: 0x0400BE7C RID: 48764
			[Token(Token = "0x401BBE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			// Token: 0x0400BE7D RID: 48765
			[Token(Token = "0x401BBE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FieldInfo[] <fields>5__2;

			// Token: 0x0400BE7E RID: 48766
			[Token(Token = "0x401BBE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__3;
		}

		// Token: 0x02000E2B RID: 3627
		[Token(Token = "0x200144F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159890", Offset = "0x159991")]
		private sealed class <UsableProperties>d__52 : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
		{
			// Token: 0x06005ED0 RID: 24272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFE")]
			[Address(RVA = "0x2C2A240", Offset = "0x2C2A341", VA = "0x2C2A240")]
			[DebuggerHidden]
			public <UsableProperties>d__52(int <>1__state)
			{
			}

			// Token: 0x06005ED1 RID: 24273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFF")]
			[Address(RVA = "0x2C2AFD0", Offset = "0x2C2B0D1", VA = "0x2C2AFD0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005ED2 RID: 24274 RVA: 0x0001F980 File Offset: 0x0001DB80
			[Token(Token = "0x6007B00")]
			[Address(RVA = "0x2C2AFE0", Offset = "0x2C2B0E1", VA = "0x2C2AFE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E6A")]
			private PropertyInfo Current
			{
				[Token(Token = "0x6007B01")]
				[Address(RVA = "0x2C2B150", Offset = "0x2C2B251", VA = "0x2C2B150", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ED4 RID: 24276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B02")]
			[Address(RVA = "0x2C2B160", Offset = "0x2C2B261", VA = "0x2C2B160", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E6B")]
			private object Current
			{
				[Token(Token = "0x6007B03")]
				[Address(RVA = "0x2C2B1C0", Offset = "0x2C2B2C1", VA = "0x2C2B1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ED6 RID: 24278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B04")]
			[Address(RVA = "0x2C2B1D0", Offset = "0x2C2B2D1", VA = "0x2C2B1D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PropertyInfo> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005ED7 RID: 24279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B05")]
			[Address(RVA = "0x2C2B2A0", Offset = "0x2C2B3A1", VA = "0x2C2B2A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BE7F RID: 48767
			[Token(Token = "0x401BBE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BE80 RID: 48768
			[Token(Token = "0x401BBE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private PropertyInfo <>2__current;

			// Token: 0x0400BE81 RID: 48769
			[Token(Token = "0x401BBE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400BE82 RID: 48770
			[Token(Token = "0x401BBE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool nonPublic;

			// Token: 0x0400BE83 RID: 48771
			[Token(Token = "0x401BBE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool <>3__nonPublic;

			// Token: 0x0400BE84 RID: 48772
			[Token(Token = "0x401BBE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type type;

			// Token: 0x0400BE85 RID: 48773
			[Token(Token = "0x401BBEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			// Token: 0x0400BE86 RID: 48774
			[Token(Token = "0x401BBEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool skipItems;

			// Token: 0x0400BE87 RID: 48775
			[Token(Token = "0x401BBEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool <>3__skipItems;

			// Token: 0x0400BE88 RID: 48776
			[Token(Token = "0x401BBED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private PropertyInfo[] <properties>5__2;

			// Token: 0x0400BE89 RID: 48777
			[Token(Token = "0x401BBEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__3;
		}
	}
}
