using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x02000258 RID: 600
[Token(Token = "0x20001E3")]
public class AIInput : CharacterInput
{
	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002A0")]
	public NavMeshAgent NavMeshAgent
	{
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x1FC3870", Offset = "0x1FC3971", VA = "0x1FC3870")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06000E96 RID: 3734 RVA: 0x000069F0 File Offset: 0x00004BF0
	// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A1")]
	public Vector3 LatestEnableNavimeshPosition
	{
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x1FC3890", Offset = "0x1FC3991", VA = "0x1FC3890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFE0", Offset = "0x19C0E1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x1FC38A0", Offset = "0x1FC39A1", VA = "0x1FC38A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFF0", Offset = "0x19C0F1")]
		protected set
		{
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A2")]
	public virtual SearchCharacterController SearchCharacterController
	{
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x1FC38B0", Offset = "0x1FC39B1", VA = "0x1FC38B0", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C000", Offset = "0x19C101")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x1FC38C0", Offset = "0x1FC39C1", VA = "0x1FC38C0", Slot = "8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C010", Offset = "0x19C111")]
		protected set
		{
		}
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A3")]
	public SharedBool IsStopBehavior
	{
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x1FC38D0", Offset = "0x1FC39D1", VA = "0x1FC38D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C020", Offset = "0x19C121")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x1FC38E0", Offset = "0x1FC39E1", VA = "0x1FC38E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C030", Offset = "0x19C131")]
		protected set
		{
		}
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A4")]
	public SharedFloat AngularSpeed
	{
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x1FC38F0", Offset = "0x1FC39F1", VA = "0x1FC38F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C040", Offset = "0x19C141")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x1FC3900", Offset = "0x1FC3A01", VA = "0x1FC3900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C050", Offset = "0x19C151")]
		protected set
		{
		}
	}

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A5")]
	public SharedFloat RotationDelta
	{
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x1FC3910", Offset = "0x1FC3A11", VA = "0x1FC3910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C060", Offset = "0x19C161")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x1FC3920", Offset = "0x1FC3A21", VA = "0x1FC3920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C070", Offset = "0x19C171")]
		protected set
		{
		}
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A6")]
	public SharedFloat ArriveDistance
	{
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x1FC3930", Offset = "0x1FC3A31", VA = "0x1FC3930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C080", Offset = "0x19C181")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x1FC3940", Offset = "0x1FC3A41", VA = "0x1FC3940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C090", Offset = "0x19C191")]
		protected set
		{
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002A7")]
	public Character ControllCharacter
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x1FC3950", Offset = "0x1FC3A51", VA = "0x1FC3950")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x1FC3960", Offset = "0x1FC3A61", VA = "0x1FC3960", Slot = "9")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x1FC39C0", Offset = "0x1FC3AC1", VA = "0x1FC39C0")]
	public void Setup()
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x1FC3CB0", Offset = "0x1FC3DB1", VA = "0x1FC3CB0", Slot = "10")]
	protected virtual void OnSetup()
	{
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x1FC3CC0", Offset = "0x1FC3DC1", VA = "0x1FC3CC0")]
	public void Relese()
	{
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x1FC3D30", Offset = "0x1FC3E31", VA = "0x1FC3D30", Slot = "11")]
	protected virtual void OnRelese()
	{
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x1FC3D40", Offset = "0x1FC3E41", VA = "0x1FC3D40", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x1FC3D50", Offset = "0x1FC3E51", VA = "0x1FC3D50", Slot = "12")]
	public virtual void SetupNavMeshAgent(Vector3 createPosition)
	{
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x1FC3FC0", Offset = "0x1FC40C1", VA = "0x1FC3FC0", Slot = "13")]
	public virtual void OnNotReturnNavMesh()
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x1FC3FD0", Offset = "0x1FC40D1", VA = "0x1FC3FD0")]
	public void SetEnableNavMesh(bool isEnable)
	{
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x1FC41B0", Offset = "0x1FC42B1", VA = "0x1FC41B0", Slot = "14")]
	public virtual float GetMoveSpeedScale(AIMoveSpeedType moveType)
	{
		return 0f;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x1FC41D0", Offset = "0x1FC42D1", VA = "0x1FC41D0", Slot = "15")]
	public virtual void SetupSearchCharacterController()
	{
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x1FC4300", Offset = "0x1FC4401", VA = "0x1FC4300")]
	public void ClearSearchCharacterController()
	{
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x1FC4310", Offset = "0x1FC4411", VA = "0x1FC4310", Slot = "16")]
	protected virtual void OnSetupSearchCharacterController()
	{
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x1FC4320", Offset = "0x1FC4421", VA = "0x1FC4320", Slot = "17")]
	public virtual void ResetSearchCharacterController()
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x1FC4380", Offset = "0x1FC4481", VA = "0x1FC4380")]
	private void OnStartInitBehaviorFirst(Behavior behavior)
	{
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x1FC4440", Offset = "0x1FC4541", VA = "0x1FC4440")]
	public void SetupBehavior(ExternalBehavior behavior, Action<BehaviorTree> callBack)
	{
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x1FC4470", Offset = "0x1FC4571", VA = "0x1FC4470")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C0A0", Offset = "0x19C1A1")]
	public IEnumerator SetupAsyncBehavior(ExternalBehavior behavior, Action<BehaviorTree> callBack)
	{
		return null;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x1FC4550", Offset = "0x1FC4651", VA = "0x1FC4550")]
	private void OnStartBehaviorFirst(Behavior behavior)
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x1FC45F0", Offset = "0x1FC46F1", VA = "0x1FC45F0", Slot = "18")]
	public virtual void ClearBehavior()
	{
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x1FC3A20", Offset = "0x1FC3B21", VA = "0x1FC3A20")]
	protected void GetVariableBehaviorParameter()
	{
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x1FC46B0", Offset = "0x1FC47B1", VA = "0x1FC46B0", Slot = "19")]
	protected virtual void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x1FC46C0", Offset = "0x1FC47C1", VA = "0x1FC46C0")]
	public void IncrementLockStopBehavior()
	{
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x1FC46D0", Offset = "0x1FC47D1", VA = "0x1FC46D0")]
	public void DecrementLockStopBehavior()
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x1FC46E0", Offset = "0x1FC47E1", VA = "0x1FC46E0", Slot = "20")]
	public virtual void SetStopBehavior(bool isStopBehavior)
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x1FC47B0", Offset = "0x1FC48B1", VA = "0x1FC47B0")]
	public void ResetBehavior(bool isEnable = true)
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x1FC3C80", Offset = "0x1FC3D81", VA = "0x1FC3C80")]
	public void SetEnableBehavior(bool isEnable)
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x1FC4840", Offset = "0x1FC4941", VA = "0x1FC4840", Slot = "21")]
	protected virtual void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x1FC4850", Offset = "0x1FC4951", VA = "0x1FC4850")]
	public AIInput()
	{
	}

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x40006C7")]
	private const float MaxNavMeshSamplePositionDistance = 10f;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x40006C8")]
	private const float SubNavMeshSamplePositionDistance = 1f;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E500", Offset = "0x15E601")]
	private Vector3 <LatestEnableNavimeshPosition>k__BackingField;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E510", Offset = "0x15E611")]
	private SearchCharacterController <SearchCharacterController>k__BackingField;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected BehaviorTree BehaviorTree;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x40")]
	private bool IsEndFirstLoadBehavior;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E530", Offset = "0x15E631")]
	private SharedBool <IsStopBehavior>k__BackingField;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E540", Offset = "0x15E641")]
	private SharedFloat <AngularSpeed>k__BackingField;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E550", Offset = "0x15E651")]
	private SharedFloat <RotationDelta>k__BackingField;

	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E560", Offset = "0x15E661")]
	private SharedFloat <ArriveDistance>k__BackingField;

	// Token: 0x0400086D RID: 2157
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x68")]
	public bool IsSetup;

	// Token: 0x0400086E RID: 2158
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x6C")]
	protected int LockStopBehaviorCounter;

	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000FFE")]
	public class SetupBehaviorEvent : UnityEvent<Behavior>
	{
		// Token: 0x06000EBF RID: 3775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x1FC4B20", Offset = "0x1FC4C21", VA = "0x1FC4B20")]
		public SetupBehaviorEvent()
		{
		}
	}

	// Token: 0x0200025A RID: 602
	[Token(Token = "0x2000FFF")]
	public enum Action
	{
		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4018E10")]
		NONE = -1,
		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4018E11")]
		AVOID,
		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4018E12")]
		ATTACK,
		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4018E13")]
		CHARGE_START,
		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4018E14")]
		CHARGE_END,
		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4018E15")]
		ITEM_PUTON,
		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4018E16")]
		ITEM_PUTIN,
		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4018E17")]
		ITEM_THROW,
		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4018E18")]
		ITEM_USE,
		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4018E19")]
		RUNEABILITY_1,
		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x4018E1A")]
		RUNEABILITY_2,
		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x4018E1B")]
		RUNEABILITY_3,
		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x4018E1C")]
		RUNEABILITY_4,
		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x4018E1D")]
		RUNEABILITY_5,
		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x4018E1E")]
		RUNEABILITY_6,
		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x4018E1F")]
		HANDCUFFS_START,
		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4018E20")]
		HANDCUFFS_CHARGE,
		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4018E21")]
		HANDCUFFS_END,
		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4018E22")]
		E_COUNT
	}

	// Token: 0x0200025B RID: 603
	[Token(Token = "0x2001000")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157280", Offset = "0x157381")]
	private sealed class <SetupAsyncBehavior>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C55")]
		[Address(RVA = "0x1FC4520", Offset = "0x1FC4621", VA = "0x1FC4520")]
		[DebuggerHidden]
		public <SetupAsyncBehavior>d__52(int <>1__state)
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0x1FC4860", Offset = "0x1FC4961", VA = "0x1FC4860", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6006C57")]
		[Address(RVA = "0x1FC4870", Offset = "0x1FC4971", VA = "0x1FC4870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDE")]
		private object Current
		{
			[Token(Token = "0x6006C58")]
			[Address(RVA = "0x1FC4AA0", Offset = "0x1FC4BA1", VA = "0x1FC4AA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C59")]
		[Address(RVA = "0x1FC4AB0", Offset = "0x1FC4BB1", VA = "0x1FC4AB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDF")]
		private object Current
		{
			[Token(Token = "0x6006C5A")]
			[Address(RVA = "0x1FC4B10", Offset = "0x1FC4C11", VA = "0x1FC4B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4018E23")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4018E24")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4018E25")]
		[FieldOffset(Offset = "0x20")]
		public AIInput <>4__this;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4018E26")]
		[FieldOffset(Offset = "0x28")]
		public ExternalBehavior behavior;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4018E27")]
		[FieldOffset(Offset = "0x30")]
		public Action<BehaviorTree> callBack;
	}
}
