using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004FE RID: 1278
[Token(Token = "0x20003A6")]
public class BeanSowingNPC : MonoBehaviour
{
	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06001F34 RID: 7988 RVA: 0x0000D260 File Offset: 0x0000B460
	// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000425")]
	public bool IsLookAtPlayer
	{
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x220B070", Offset = "0x220B171", VA = "0x220B070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FA70", Offset = "0x19FB71")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x220B080", Offset = "0x220B181", VA = "0x220B080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FA80", Offset = "0x19FB81")]
		set
		{
		}
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x22098A0", Offset = "0x22099A1", VA = "0x22098A0")]
	public void Init(FestivalCharacterController _controller)
	{
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x220B090", Offset = "0x220B191", VA = "0x220B090")]
	private void BeanGenerator(BeanID _bean_id, Vector3 _dir)
	{
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x220A8B0", Offset = "0x220A9B1", VA = "0x220A8B0")]
	public void Sowing(SowingPattern _pattern, BeanID _bean_id)
	{
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x220B2E0", Offset = "0x220B3E1", VA = "0x220B2E0")]
	public BeanSowingNPC()
	{
	}

	// Token: 0x0400661F RID: 26143
	[Token(Token = "0x400608A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165720", Offset = "0x165821")]
	private bool <IsLookAtPlayer>k__BackingField;

	// Token: 0x04006620 RID: 26144
	[Token(Token = "0x400608B")]
	[FieldOffset(Offset = "0x20")]
	private FestivalCharacterController controller;

	// Token: 0x04006621 RID: 26145
	[Token(Token = "0x400608C")]
	[FieldOffset(Offset = "0x28")]
	private readonly Vector3[] BEAN_DIR_WAY2;

	// Token: 0x04006622 RID: 26146
	[Token(Token = "0x400608D")]
	[FieldOffset(Offset = "0x30")]
	private readonly Vector3[] BEAN_DIR_WAY3;

	// Token: 0x04006623 RID: 26147
	[Token(Token = "0x400608E")]
	[FieldOffset(Offset = "0x38")]
	private readonly Vector3[] BEAN_DIR_WAY4;

	// Token: 0x04006624 RID: 26148
	[Token(Token = "0x400608F")]
	[FieldOffset(Offset = "0x40")]
	private readonly Vector3[] BEAN_DIR_WAY5;

	// Token: 0x04006625 RID: 26149
	[Token(Token = "0x4006090")]
	[FieldOffset(Offset = "0x48")]
	private List<BeanID> beanListWay4;

	// Token: 0x04006626 RID: 26150
	[Token(Token = "0x4006091")]
	[FieldOffset(Offset = "0x50")]
	private List<BeanID> beanListWay5;

	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20010E1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C60", Offset = "0x157D61")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001F3B RID: 7995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0x220B8A0", Offset = "0x220B9A1", VA = "0x220B8A0")]
		public <>c()
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0x220B8B0", Offset = "0x220B9B1", VA = "0x220B8B0")]
		internal Guid <Sowing>b__13_0(BeanID a)
		{
			return default(Guid);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0x220B920", Offset = "0x220BA21", VA = "0x220B920")]
		internal Guid <Sowing>b__13_1(BeanID a)
		{
			return default(Guid);
		}

		// Token: 0x04006627 RID: 26151
		[Token(Token = "0x4019208")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BeanSowingNPC.<>c <>9;

		// Token: 0x04006628 RID: 26152
		[Token(Token = "0x4019209")]
		[FieldOffset(Offset = "0x8")]
		public static Func<BeanID, Guid> <>9__13_0;

		// Token: 0x04006629 RID: 26153
		[Token(Token = "0x401920A")]
		[FieldOffset(Offset = "0x10")]
		public static Func<BeanID, Guid> <>9__13_1;
	}
}
