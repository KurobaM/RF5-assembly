using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x2000218")]
public class MonsterSoulController : CharaSoulController<MonsterControllerBase>
{
	// Token: 0x06001150 RID: 4432 RVA: 0x00007F50 File Offset: 0x00006150
	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x1E71ED0", Offset = "0x1E71FD1", VA = "0x1E71ED0", Slot = "6")]
	public override bool DoPlay(Collider target, Action callback)
	{
		return default(bool);
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x1E720B0", Offset = "0x1E721B1", VA = "0x1E720B0", Slot = "7")]
	public override void DoEnd()
	{
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x1E72120", Offset = "0x1E72221", VA = "0x1E72120")]
	public MonsterSoulController()
	{
	}

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x28")]
	private Action m_Callback;

	// Token: 0x020002A5 RID: 677
	[Token(Token = "0x2001015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572E0", Offset = "0x1573E1")]
	private sealed class <>c__DisplayClass1_0
	{
		// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0x1E720A0", Offset = "0x1E721A1", VA = "0x1E720A0")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7B")]
		[Address(RVA = "0x1E72170", Offset = "0x1E72271", VA = "0x1E72170")]
		internal void <DoPlay>b__0()
		{
		}

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x4018E86")]
		[FieldOffset(Offset = "0x10")]
		public MonsterSoulController <>4__this;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x4018E87")]
		[FieldOffset(Offset = "0x18")]
		public Collider target;
	}

	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x2001016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572F0", Offset = "0x1573F1")]
	private sealed class <>c__DisplayClass1_1
	{
		// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7C")]
		[Address(RVA = "0x1E72390", Offset = "0x1E72491", VA = "0x1E72390")]
		public <>c__DisplayClass1_1()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7D")]
		[Address(RVA = "0x1E723A0", Offset = "0x1E724A1", VA = "0x1E723A0")]
		internal void <DoPlay>b__1(ParticleSystem effect)
		{
		}

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x4018E88")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 deadEffectPosition;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x4018E89")]
		[FieldOffset(Offset = "0x20")]
		public MonsterSoulController.<>c__DisplayClass1_0 CS$<>8__locals1;
	}
}
