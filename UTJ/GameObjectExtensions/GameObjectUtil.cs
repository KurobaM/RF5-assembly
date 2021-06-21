using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ.GameObjectExtensions
{
	// Token: 0x02000C24 RID: 3108
	[Token(Token = "0x20007F7")]
	public static class GameObjectUtil
	{
		// Token: 0x06004EF9 RID: 20217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A2")]
		public static IEnumerable<T> FindComponentsOfType<T>() where T : Component
		{
			return null;
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x212AE10", Offset = "0x212AF11", VA = "0x212AE10")]
		public static IEnumerable<GameObject> GetAllGameObjects()
		{
			return null;
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A4")]
		public static Dictionary<string, T> BuildNameToComponentMap<T>(this GameObject rootObject, bool includeInactive) where T : Component
		{
			return null;
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x212AF30", Offset = "0x212B031", VA = "0x212AF30")]
		public static IEnumerable<Transform> GetAllBones(this GameObject rootObject)
		{
			return null;
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x212B080", Offset = "0x212B181", VA = "0x212B080")]
		public static Transform FindChildByName(this GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = GameObjectUtil.SearchOptions.IgnoreNamespace)
		{
			return null;
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A7")]
		public static T FindChildComponentByName<T>(this GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = GameObjectUtil.SearchOptions.IgnoreNamespace) where T : Component
		{
			return null;
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A8")]
		public static T[] FindChildComponentsByName<T>(this GameObject inRoot, string[] inNames, GameObjectUtil.SearchOptions searchOptions = GameObjectUtil.SearchOptions.IgnoreNamespace) where T : Component
		{
			return null;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x212B0F0", Offset = "0x212B1F1", VA = "0x212B0F0")]
		public static string RemoveNamespaceFromName(string inName)
		{
			return null;
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x000193B0 File Offset: 0x000175B0
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x212B1C0", Offset = "0x212B2C1", VA = "0x212B1C0")]
		public static int GetTransformDepth(Transform inObject)
		{
			return 0;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x212B270", Offset = "0x212B371", VA = "0x212B270")]
		public static string GetUniqueName(string desiredName)
		{
			return null;
		}

		// Token: 0x02000C25 RID: 3109
		[Token(Token = "0x20013A8")]
		public enum SearchOptions
		{
			// Token: 0x0400AFD1 RID: 45009
			[Token(Token = "0x401B7E9")]
			None,
			// Token: 0x0400AFD2 RID: 45010
			[Token(Token = "0x401B7EA")]
			IgnoreNamespace
		}

		// Token: 0x02000C26 RID: 3110
		[Token(Token = "0x20013A9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159690", Offset = "0x159791")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F04 RID: 20228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007826")]
			[Address(RVA = "0x212B4E0", Offset = "0x212B5E1", VA = "0x212B4E0")]
			public <>c()
			{
			}

			// Token: 0x06004F05 RID: 20229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007827")]
			[Address(RVA = "0x212B4F0", Offset = "0x212B5F1", VA = "0x212B4F0")]
			internal GameObject <GetAllGameObjects>b__2_0(Transform item)
			{
				return null;
			}

			// Token: 0x06004F06 RID: 20230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007828")]
			[Address(RVA = "0x212B510", Offset = "0x212B611", VA = "0x212B510")]
			internal string <GetUniqueName>b__10_0(Transform item)
			{
				return null;
			}

			// Token: 0x0400AFD3 RID: 45011
			[Token(Token = "0x401B7EB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameObjectUtil.<>c <>9;

			// Token: 0x0400AFD4 RID: 45012
			[Token(Token = "0x401B7EC")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> <>9__2_0;

			// Token: 0x0400AFD5 RID: 45013
			[Token(Token = "0x401B7ED")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Transform, string> <>9__10_0;
		}

		// Token: 0x02000C27 RID: 3111
		[Token(Token = "0x20013AA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1596A0", Offset = "0x1597A1")]
		private sealed class <>c__DisplayClass7_0<T> where T : Component
		{
			// Token: 0x06004F07 RID: 20231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007829")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06004F08 RID: 20232 RVA: 0x000193C8 File Offset: 0x000175C8
			[Token(Token = "0x600782A")]
			internal bool <FindChildComponentsByName>b__0(string searchName)
			{
				return default(bool);
			}

			// Token: 0x06004F09 RID: 20233 RVA: 0x000193E0 File Offset: 0x000175E0
			[Token(Token = "0x600782B")]
			internal bool <FindChildComponentsByName>b__1(string searchName)
			{
				return default(bool);
			}

			// Token: 0x0400AFD6 RID: 45014
			[Token(Token = "0x401B7EE")]
			[FieldOffset(Offset = "0x0")]
			public string childName;
		}
	}
}
