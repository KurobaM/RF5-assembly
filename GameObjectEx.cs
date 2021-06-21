using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C6 RID: 1222
[Token(Token = "0x2000388")]
public static class GameObjectEx
{
	// Token: 0x06001E01 RID: 7681 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x23FA860", Offset = "0x23FA961", VA = "0x23FA860")]
	public static bool IsActive(this GameObject self)
	{
		return default(bool);
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x23FA880", Offset = "0x23FA981", VA = "0x23FA880")]
	public static string FullName(this GameObject self)
	{
		return null;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x23FAA50", Offset = "0x23FAB51", VA = "0x23FAA50")]
	public static void TrimCloneSuffix(this GameObject self)
	{
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EE")]
	public static T SafeGetComponent<T>(this GameObject self) where T : Component
	{
		return null;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x23FAB50", Offset = "0x23FAC51", VA = "0x23FAB50")]
	public static Component SafeGetComponent(this GameObject self, Type type)
	{
		return null;
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x23FAC10", Offset = "0x23FAD11", VA = "0x23FAC10")]
	public static GameObject[] GetChildren(this GameObject self, bool includeInactive = false)
	{
		return null;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x23FADE0", Offset = "0x23FAEE1", VA = "0x23FADE0")]
	public static GameObject[] GetChildrenWithoutGrandchildren(this GameObject self)
	{
		return null;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F2")]
	public static T[] GetComponentsInChildrenWithoutSelf<T>(this GameObject self, bool includeInactive = false) where T : Component
	{
		return null;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x23FB1F0", Offset = "0x23FB2F1", VA = "0x23FB1F0")]
	public static void RemoveChildren(this GameObject self)
	{
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F4")]
	public static void RemoveComponent<T>(this GameObject self) where T : Component
	{
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F5")]
	public static void RemoveComponentImmediate<T>(this GameObject self) where T : Component
	{
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F6")]
	public static void RemoveComponents<T>(this GameObject self) where T : Component
	{
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x0000CE10 File Offset: 0x0000B010
	[Token(Token = "0x60019F7")]
	public static bool HasComponent<T>(this GameObject self) where T : Component
	{
		return default(bool);
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0000CE28 File Offset: 0x0000B028
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x23FB310", Offset = "0x23FB411", VA = "0x23FB310")]
	public static bool HasComponent(this GameObject self, Type type)
	{
		return default(bool);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x0000CE40 File Offset: 0x0000B040
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x23FB3B0", Offset = "0x23FB4B1", VA = "0x23FB3B0")]
	public static bool HasComponent(this GameObject self, string typeName)
	{
		return default(bool);
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x23FB450", Offset = "0x23FB551", VA = "0x23FB450")]
	public static Transform Find(this GameObject self, string name)
	{
		return null;
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x23FB490", Offset = "0x23FB591", VA = "0x23FB490")]
	public static GameObject FindGameObject(this GameObject self, string name)
	{
		return null;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x23FB560", Offset = "0x23FB661", VA = "0x23FB560")]
	public static GameObject FindGameObjectDeep(this GameObject self, string name, bool includeInactive = false)
	{
		return null;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FD")]
	public static T FindComponent<T>(this GameObject self, string name) where T : Component
	{
		return null;
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x0000CE58 File Offset: 0x0000B058
	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x23FB650", Offset = "0x23FB751", VA = "0x23FB650")]
	public static bool HasChild(this GameObject self)
	{
		return default(bool);
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x23FB690", Offset = "0x23FB791", VA = "0x23FB690")]
	public static GameObject GetChild(this GameObject self, int index)
	{
		return null;
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x23FB760", Offset = "0x23FB861", VA = "0x23FB760")]
	public static void SetParent(this GameObject self, Component parent, bool worldPositionStays = true)
	{
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x23FB7C0", Offset = "0x23FB8C1", VA = "0x23FB7C0")]
	public static void SetParent(this GameObject self, GameObject parent, bool worldPositionStays = true)
	{
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x0000CE70 File Offset: 0x0000B070
	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x23FB820", Offset = "0x23FB921", VA = "0x23FB820")]
	public static bool HasParent(this GameObject self)
	{
		return default(bool);
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x23FA990", Offset = "0x23FAA91", VA = "0x23FA990")]
	public static GameObject GetParent(this GameObject self)
	{
		return null;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x23FB8B0", Offset = "0x23FB9B1", VA = "0x23FB8B0")]
	public static GameObject GetRoot(this GameObject self)
	{
		return null;
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x23FB970", Offset = "0x23FBA71", VA = "0x23FB970")]
	public static void SetLayer(this GameObject self, string layerName)
	{
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x23FB9B0", Offset = "0x23FBAB1", VA = "0x23FB9B0")]
	public static void SetLayerRecursively(this GameObject self, int layer)
	{
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x23FBC80", Offset = "0x23FBD81", VA = "0x23FBC80")]
	public static void SetLayerRecursively(this GameObject self, string layerName)
	{
	}

	// Token: 0x04006437 RID: 25655
	[Token(Token = "0x4005EF7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CLONE_SUFFIX;

	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20010C7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AF0", Offset = "0x157BF1")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06001E1F RID: 7711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F01")]
		[Address(RVA = "0x23FADD0", Offset = "0x23FAED1", VA = "0x23FADD0")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0000CE88 File Offset: 0x0000B088
		[Token(Token = "0x6006F02")]
		[Address(RVA = "0x23FBE10", Offset = "0x23FBF11", VA = "0x23FBE10")]
		internal bool <GetChildren>b__0(Transform child)
		{
			return default(bool);
		}

		// Token: 0x04006438 RID: 25656
		[Token(Token = "0x40191B3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject self;
	}

	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20010C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B00", Offset = "0x157C01")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F04")]
		[Address(RVA = "0x23FBDE0", Offset = "0x23FBEE1", VA = "0x23FBDE0")]
		public <>c()
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F05")]
		[Address(RVA = "0x23FBDF0", Offset = "0x23FBEF1", VA = "0x23FBDF0")]
		internal GameObject <GetChildren>b__6_1(Transform child)
		{
			return null;
		}

		// Token: 0x04006439 RID: 25657
		[Token(Token = "0x40191B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GameObjectEx.<>c <>9;

		// Token: 0x0400643A RID: 25658
		[Token(Token = "0x40191B5")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, GameObject> <>9__6_1;
	}

	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20010C9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B10", Offset = "0x157C11")]
	private sealed class <>c__DisplayClass8_0<T> where T : Component
	{
		// Token: 0x06001E24 RID: 7716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F06")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x6006F07")]
		internal bool <GetComponentsInChildrenWithoutSelf>b__0(T child)
		{
			return default(bool);
		}

		// Token: 0x0400643B RID: 25659
		[Token(Token = "0x40191B6")]
		[FieldOffset(Offset = "0x0")]
		public GameObject self;
	}
}
