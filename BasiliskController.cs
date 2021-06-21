using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006C3 RID: 1731
[Token(Token = "0x20004D4")]
public class BasiliskController : BossMonsterContoroller
{
	// Token: 0x06002A5E RID: 10846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B9")]
	[Address(RVA = "0x22A41A0", Offset = "0x22A42A1", VA = "0x22A41A0")]
	private void SetPreWarmParticleSystem(Transform particleTransform, bool isPreWarm)
	{
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023BA")]
	[Address(RVA = "0x22A4280", Offset = "0x22A4381", VA = "0x22A4280")]
	private void SetupWearFire()
	{
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023BB")]
	[Address(RVA = "0x22A4850", Offset = "0x22A4951", VA = "0x22A4850")]
	private void UpdateWearFire()
	{
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x00010548 File Offset: 0x0000E748
	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x22A48F0", Offset = "0x22A49F1", VA = "0x22A48F0")]
	private int GetRandomOnWearFire()
	{
		return 0;
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x00010560 File Offset: 0x0000E760
	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x22A4A00", Offset = "0x22A4B01", VA = "0x22A4A00")]
	private int GetWearFireCount()
	{
		return 0;
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x00010578 File Offset: 0x0000E778
	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x22A4AB0", Offset = "0x22A4BB1", VA = "0x22A4AB0")]
	private float GetWearFireDamageDownRate()
	{
		return 0f;
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x22A4BA0", Offset = "0x22A4CA1", VA = "0x22A4BA0", Slot = "131")]
	protected override void OnRegistCollider()
	{
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x22A4C00", Offset = "0x22A4D01", VA = "0x22A4C00", Slot = "130")]
	public override void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision)
	{
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x22A4CB0", Offset = "0x22A4DB1", VA = "0x22A4CB0")]
	private void SetTailOverwrapPlayer(bool isOverwrap)
	{
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x22A4FA0", Offset = "0x22A50A1", VA = "0x22A4FA0")]
	private void UpdateTailCollider()
	{
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x22A5050", Offset = "0x22A5151", VA = "0x22A5050", Slot = "116")]
	protected override void OnResetActionScriptAction()
	{
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x22A5080", Offset = "0x22A5181", VA = "0x22A5080", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x22A50F0", Offset = "0x22A51F1", VA = "0x22A50F0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x00010590 File Offset: 0x0000E790
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x22A51A0", Offset = "0x22A52A1", VA = "0x22A51A0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x22A52D0", Offset = "0x22A53D1", VA = "0x22A52D0", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x22A5390", Offset = "0x22A5491", VA = "0x22A5390", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x22A5460", Offset = "0x22A5561", VA = "0x22A5460")]
	public void OnHitAttack(Collider other, Collider attackCollider)
	{
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x22A5A60", Offset = "0x22A5B61", VA = "0x22A5A60")]
	public BasiliskController()
	{
	}

	// Token: 0x04007225 RID: 29221
	[Token(Token = "0x40069DD")]
	private const float keepOnFireTime = 8f;

	// Token: 0x04007226 RID: 29222
	[Token(Token = "0x40069DE")]
	private const float onFireTime = 8f;

	// Token: 0x04007227 RID: 29223
	[Token(Token = "0x40069DF")]
	private const float activeColliderTime = 1f;

	// Token: 0x04007228 RID: 29224
	[Token(Token = "0x40069E0")]
	private const float TailColliderOffVelocity = 0.1f;

	// Token: 0x04007229 RID: 29225
	[Token(Token = "0x40069E1")]
	[FieldOffset(Offset = "0x508")]
	private readonly int[] WearFireCountDamageDown;

	// Token: 0x0400722A RID: 29226
	[Token(Token = "0x40069E2")]
	private const float DefaultNavmeshAgentRadius = 0.5f;

	// Token: 0x0400722B RID: 29227
	[Token(Token = "0x40069E3")]
	private const float WaitNavmeshAgentRadius = 3f;

	// Token: 0x0400722C RID: 29228
	[Token(Token = "0x40069E4")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	private BodyPartsCollision Wait_1_TailCollision;

	// Token: 0x0400722D RID: 29229
	[Token(Token = "0x40069E5")]
	[FieldOffset(Offset = "0x518")]
	[SerializeField]
	private BodyPartsCollision Wait_2_TailCollision;

	// Token: 0x0400722E RID: 29230
	[Token(Token = "0x40069E6")]
	[FieldOffset(Offset = "0x520")]
	private List<BasiliskController.WearFireController> WearFireControllerList;

	// Token: 0x0400722F RID: 29231
	[Token(Token = "0x40069E7")]
	[FieldOffset(Offset = "0x528")]
	private List<int> IndexList;

	// Token: 0x04007230 RID: 29232
	[Token(Token = "0x40069E8")]
	[FieldOffset(Offset = "0x530")]
	private List<BodyPartsCollision> TailCollisionList;

	// Token: 0x04007231 RID: 29233
	[Token(Token = "0x40069E9")]
	[FieldOffset(Offset = "0x538")]
	private int LocomotionHash;

	// Token: 0x04007232 RID: 29234
	[Token(Token = "0x40069EA")]
	[FieldOffset(Offset = "0x53C")]
	private bool IsTailOverwrap;

	// Token: 0x04007233 RID: 29235
	[Token(Token = "0x40069EB")]
	[FieldOffset(Offset = "0x540")]
	private DamageInfo WearFireDamageInformation;

	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x2001178")]
	public class WearFireController
	{
		// Token: 0x06002A70 RID: 10864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007190")]
		[Address(RVA = "0x2207180", Offset = "0x2207281", VA = "0x2207180")]
		public WearFireController(float toKeepOnTime, float toOnTime, ParticleSystem effect, AttackCollider attackCollider)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x17000D15")]
		public bool IsOn
		{
			[Token(Token = "0x6007191")]
			[Address(RVA = "0x2207380", Offset = "0x2207481", VA = "0x2207380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x17000D16")]
		public bool CanOff
		{
			[Token(Token = "0x6007192")]
			[Address(RVA = "0x2207390", Offset = "0x2207491", VA = "0x2207390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007193")]
		[Address(RVA = "0x22073A0", Offset = "0x22074A1", VA = "0x22073A0")]
		private void SetActiveEffect(bool isActive)
		{
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007194")]
		[Address(RVA = "0x2207430", Offset = "0x2207531", VA = "0x2207430")]
		private void SetEnable(bool isActive)
		{
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007195")]
		[Address(RVA = "0x2207500", Offset = "0x2207601", VA = "0x2207500")]
		public void SetAttackColliderEnable(bool isActive)
		{
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007196")]
		[Address(RVA = "0x22075C0", Offset = "0x22076C1", VA = "0x22075C0")]
		private void UpdateAttackCollider()
		{
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007197")]
		[Address(RVA = "0x2207690", Offset = "0x2207791", VA = "0x2207690")]
		public void Off(bool isForce = false)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007198")]
		[Address(RVA = "0x22076C0", Offset = "0x22077C1", VA = "0x22076C0")]
		public void On()
		{
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007199")]
		[Address(RVA = "0x22076E0", Offset = "0x22077E1", VA = "0x22076E0")]
		private void OffUpdate()
		{
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719A")]
		[Address(RVA = "0x2207750", Offset = "0x2207851", VA = "0x2207750")]
		private void KeepOnUpdate()
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719B")]
		[Address(RVA = "0x22077B0", Offset = "0x22078B1", VA = "0x22077B0")]
		public void Update()
		{
		}

		// Token: 0x04007234 RID: 29236
		[Token(Token = "0x40194BB")]
		[FieldOffset(Offset = "0x10")]
		private BasiliskController.WearFireController.State CurrentState;

		// Token: 0x04007235 RID: 29237
		[Token(Token = "0x40194BC")]
		[FieldOffset(Offset = "0x18")]
		private ParticleSystem Effect;

		// Token: 0x04007236 RID: 29238
		[Token(Token = "0x40194BD")]
		[FieldOffset(Offset = "0x20")]
		private AttackCollider AttackCollider;

		// Token: 0x04007237 RID: 29239
		[Token(Token = "0x40194BE")]
		[FieldOffset(Offset = "0x28")]
		private Action[] UpdateStates;

		// Token: 0x04007238 RID: 29240
		[Token(Token = "0x40194BF")]
		[FieldOffset(Offset = "0x30")]
		private float Timer;

		// Token: 0x04007239 RID: 29241
		[Token(Token = "0x40194C0")]
		[FieldOffset(Offset = "0x34")]
		private float ToKeepOnTime;

		// Token: 0x0400723A RID: 29242
		[Token(Token = "0x40194C1")]
		[FieldOffset(Offset = "0x38")]
		private float ToOnTime;

		// Token: 0x0400723B RID: 29243
		[Token(Token = "0x40194C2")]
		[FieldOffset(Offset = "0x3C")]
		private float ActiveColliderTimer;

		// Token: 0x0400723C RID: 29244
		[Token(Token = "0x40194C3")]
		[FieldOffset(Offset = "0x40")]
		private bool IsColliderLock;

		// Token: 0x020006C5 RID: 1733
		[Token(Token = "0x200164A")]
		public enum State
		{
			// Token: 0x0400723E RID: 29246
			[Token(Token = "0x401C3F1")]
			Off,
			// Token: 0x0400723F RID: 29247
			[Token(Token = "0x401C3F2")]
			KeepOn,
			// Token: 0x04007240 RID: 29248
			[Token(Token = "0x401C3F3")]
			On,
			// Token: 0x04007241 RID: 29249
			[Token(Token = "0x401C3F4")]
			eCount
		}
	}

	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x2001179")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158330", Offset = "0x158431")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002A7D RID: 10877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719D")]
		[Address(RVA = "0x2207020", Offset = "0x2207121", VA = "0x2207020")]
		public <>c()
		{
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x600719E")]
		[Address(RVA = "0x2207030", Offset = "0x2207131", VA = "0x2207030")]
		internal bool <SetupWearFire>b__17_0(AttackCollider component)
		{
			return default(bool);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x600719F")]
		[Address(RVA = "0x22070A0", Offset = "0x22071A1", VA = "0x22070A0")]
		internal bool <SetupWearFire>b__17_1(AttackCollider component)
		{
			return default(bool);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x60071A0")]
		[Address(RVA = "0x2207110", Offset = "0x2207211", VA = "0x2207110")]
		internal bool <SetupWearFire>b__17_2(AttackCollider component)
		{
			return default(bool);
		}

		// Token: 0x04007242 RID: 29250
		[Token(Token = "0x40194C4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BasiliskController.<>c <>9;

		// Token: 0x04007243 RID: 29251
		[Token(Token = "0x40194C5")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AttackCollider> <>9__17_0;

		// Token: 0x04007244 RID: 29252
		[Token(Token = "0x40194C6")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<AttackCollider> <>9__17_1;

		// Token: 0x04007245 RID: 29253
		[Token(Token = "0x40194C7")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<AttackCollider> <>9__17_2;
	}
}
