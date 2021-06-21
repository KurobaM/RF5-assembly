using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C1 RID: 1217
[Token(Token = "0x2000386")]
public static class ComponentEx
{
	// Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x20DD530", Offset = "0x20DD631", VA = "0x20DD530")]
	public static void SetGameObjectActive(this Component self, bool isActive)
	{
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0000CD20 File Offset: 0x0000AF20
	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x20DD570", Offset = "0x20DD671", VA = "0x20DD570")]
	public static bool IsGameObjectActive(this Component self)
	{
		return default(bool);
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019C9")]
	public static T AddComponent<T>(this Component self) where T : Component
	{
		return null;
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CA")]
	public static T SafeGetComponent<T>(this Component self) where T : Component
	{
		return null;
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x20DD5A0", Offset = "0x20DD6A1", VA = "0x20DD5A0")]
	public static GameObject[] GetChildren(this Component self, bool includeInactive = false)
	{
		return null;
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x20DD770", Offset = "0x20DD871", VA = "0x20DD770")]
	public static GameObject[] GetChildrenWithoutGrandchildren(this Component self)
	{
		return null;
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CD")]
	public static T[] GetComponentsInChildrenWithoutSelf<T>(this Component self, bool includeInactive = false) where T : Component
	{
		return null;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x20DDB80", Offset = "0x20DDC81", VA = "0x20DDB80")]
	public static void RemoveChildren(this Component self)
	{
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CF")]
	public static void RemoveComponent<T>(this Component self) where T : Component
	{
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019D0")]
	public static void RemoveComponentImmediate<T>(this Component self) where T : Component
	{
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019D1")]
	public static void RemoveComponents<T>(this Component self) where T : Component
	{
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x0000CD38 File Offset: 0x0000AF38
	[Token(Token = "0x60019D2")]
	public static bool HasComponent<T>(this Component self) where T : Component
	{
		return default(bool);
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x20DDC70", Offset = "0x20DDD71", VA = "0x20DDC70")]
	public static Transform Find(this Component self, string name)
	{
		return null;
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x20DDCB0", Offset = "0x20DDDB1", VA = "0x20DDCB0")]
	public static Transform FindDeep(this Component self, string name, bool includeInactive = false)
	{
		return null;
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x20DDD90", Offset = "0x20DDE91", VA = "0x20DDD90")]
	public static GameObject FindGameObject(this Component self, string name)
	{
		return null;
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x20DDE60", Offset = "0x20DDF61", VA = "0x20DDE60")]
	public static GameObject FindGameObjectDeep(this Component self, string name, bool includeInactive = false)
	{
		return null;
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D7")]
	public static T FindComponent<T>(this Component self, string name) where T : Component
	{
		return null;
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x0000CD50 File Offset: 0x0000AF50
	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x20DDF30", Offset = "0x20DE031", VA = "0x20DDF30")]
	public static bool HasChild(this Component self)
	{
		return default(bool);
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x20DDF70", Offset = "0x20DE071", VA = "0x20DDF70")]
	public static GameObject GetChild(this Component self, int index)
	{
		return null;
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x20DE040", Offset = "0x20DE141", VA = "0x20DE040")]
	public static void SetParent(this Component self, Component parent)
	{
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x20DE090", Offset = "0x20DE191", VA = "0x20DE090")]
	public static void SetParent(this Component self, Component parent, bool worldPositionStays)
	{
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x20DE0F0", Offset = "0x20DE1F1", VA = "0x20DE0F0")]
	public static void SetParent(this Component self, GameObject parent)
	{
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x20DE140", Offset = "0x20DE241", VA = "0x20DE140")]
	public static void SetParent(this Component self, GameObject parent, bool worldPositionStays)
	{
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x0000CD68 File Offset: 0x0000AF68
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x20DE1A0", Offset = "0x20DE2A1", VA = "0x20DE1A0")]
	public static bool HasParent(this Component self)
	{
		return default(bool);
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x20DE230", Offset = "0x20DE331", VA = "0x20DE230")]
	public static GameObject GetParent(this Component self)
	{
		return null;
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x20DE2F0", Offset = "0x20DE3F1", VA = "0x20DE2F0")]
	public static GameObject GetRoot(this Component self)
	{
		return null;
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x20DE3B0", Offset = "0x20DE4B1", VA = "0x20DE3B0")]
	public static void SetLayer(this Component self, string layerName)
	{
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x0000CD80 File Offset: 0x0000AF80
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x20DE400", Offset = "0x20DE501", VA = "0x20DE400")]
	public static int GetLayer(this Component self)
	{
		return 0;
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x0000CD98 File Offset: 0x0000AF98
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x20DE430", Offset = "0x20DE531", VA = "0x20DE430")]
	public static bool CompLayer(this Component self, int layer)
	{
		return default(bool);
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x20DE470", Offset = "0x20DE571", VA = "0x20DE470")]
	public static bool CompLayerMask(this Component self, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x20DE4C0", Offset = "0x20DE5C1", VA = "0x20DE4C0")]
	public static void SetLayerRecursively(this Component self, int layer)
	{
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x20DE760", Offset = "0x20DE861", VA = "0x20DE760")]
	public static void SetLayerRecursively(this Component self, string layerName)
	{
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E7")]
	public static T GetCopyOf<T>(this Component comp, T other) where T : Component
	{
		return null;
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E8")]
	public static T AddComponent<T>(this GameObject go, T toAdd) where T : Component
	{
		return null;
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x20DE790", Offset = "0x20DE891", VA = "0x20DE790")]
	public static void MeshNormalAverage(Mesh mesh)
	{
	}

	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20010C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AC0", Offset = "0x157BC1")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFA")]
		[Address(RVA = "0x20DD760", Offset = "0x20DD861", VA = "0x20DD760")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x6006EFB")]
		[Address(RVA = "0x20DEF00", Offset = "0x20DF001", VA = "0x20DEF00")]
		internal bool <GetChildren>b__0(Transform child)
		{
			return default(bool);
		}

		// Token: 0x04006433 RID: 25651
		[Token(Token = "0x40191AF")]
		[FieldOffset(Offset = "0x10")]
		public Component self;
	}

	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20010C5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AD0", Offset = "0x157BD1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0x20DEED0", Offset = "0x20DEFD1", VA = "0x20DEED0")]
		public <>c()
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0x20DEEE0", Offset = "0x20DEFE1", VA = "0x20DEEE0")]
		internal GameObject <GetChildren>b__4_1(Transform child)
		{
			return null;
		}

		// Token: 0x04006434 RID: 25652
		[Token(Token = "0x40191B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ComponentEx.<>c <>9;

		// Token: 0x04006435 RID: 25653
		[Token(Token = "0x40191B1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, GameObject> <>9__4_1;
	}

	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20010C6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AE0", Offset = "0x157BE1")]
	private sealed class <>c__DisplayClass6_0<T> where T : Component
	{
		// Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFF")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x6006F00")]
		internal bool <GetComponentsInChildrenWithoutSelf>b__0(T child)
		{
			return default(bool);
		}

		// Token: 0x04006436 RID: 25654
		[Token(Token = "0x40191B2")]
		[FieldOffset(Offset = "0x0")]
		public Component self;
	}
}
