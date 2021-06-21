using System;
using Il2CppDummyDll;
using UnityEngine.Events;

// Token: 0x0200009B RID: 155
[Token(Token = "0x2000078")]
public class MonsterProjectileEvent
{
	// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1E6F280", Offset = "0x1E6F381", VA = "0x1E6F280")]
	public void Reset()
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1E6F2E0", Offset = "0x1E6F3E1", VA = "0x1E6F2E0")]
	public MonsterProjectileEvent()
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1E6F520", Offset = "0x1E6F621", VA = "0x1E6F520")]
	public MonsterProjectileEvent(MonsterProjectileEvent other)
	{
	}

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x10")]
	[NonSerialized]
	public MonsterProjectileEvent.ActionScriptEvent OnCreatedProjectileEvent;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public MonsterProjectileEvent.ActionScriptEvent OnDestroyProjectileEvent;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public MonsterProjectileEvent.HitActionScriptEvent OnHitEvent;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public MonsterProjectileEvent.ActionScriptEvent OnHitGroundEvent;

	// Token: 0x0200009C RID: 156
	[Token(Token = "0x2000FAD")]
	public class ActionScriptEvent : UnityEvent<MonsterProjectileActionScriptsController, int>
	{
		// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x1E6F480", Offset = "0x1E6F581", VA = "0x1E6F480")]
		public ActionScriptEvent()
		{
		}
	}

	// Token: 0x0200009D RID: 157
	[Token(Token = "0x2000FAE")]
	public class HitActionScriptEvent : UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>
	{
		// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0x1E6F4D0", Offset = "0x1E6F5D1", VA = "0x1E6F4D0")]
		public HitActionScriptEvent()
		{
		}
	}

	// Token: 0x0200009E RID: 158
	[Token(Token = "0x2000FAF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157040", Offset = "0x157141")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0x1E6F840", Offset = "0x1E6F941", VA = "0x1E6F840")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0x1E6F850", Offset = "0x1E6F951", VA = "0x1E6F850")]
		internal void <.ctor>b__0(MonsterProjectileActionScriptsController controller, int index)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0x1E6F8D0", Offset = "0x1E6F9D1", VA = "0x1E6F8D0")]
		internal void <.ctor>b__1(MonsterProjectileActionScriptsController controller, int index)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0x1E6F950", Offset = "0x1E6FA51", VA = "0x1E6F950")]
		internal void <.ctor>b__2(CharacterBase characterBase, MonsterProjectileActionScriptsController controller, int actionIndex)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA2")]
		[Address(RVA = "0x1E6F9E0", Offset = "0x1E6FAE1", VA = "0x1E6F9E0")]
		internal void <.ctor>b__3(MonsterProjectileActionScriptsController controller, int index)
		{
		}

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x4018CE4")]
		[FieldOffset(Offset = "0x10")]
		public MonsterProjectileEvent other;
	}
}
