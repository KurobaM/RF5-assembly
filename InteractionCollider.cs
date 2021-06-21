using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000264 RID: 612
[Token(Token = "0x20001E7")]
public class InteractionCollider : InteractionColliderBase
{
	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AD")]
	public FocusInterface CurrentFocus
	{
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x2232200", Offset = "0x2232301", VA = "0x2232200")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x2232210", Offset = "0x2232311", VA = "0x2232210")]
		private set
		{
		}
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AE")]
	public Collider CurrentFocusCollider
	{
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x2232490", Offset = "0x2232591", VA = "0x2232490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C230", Offset = "0x19C331")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x22324A0", Offset = "0x22325A1", VA = "0x22324A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C240", Offset = "0x19C341")]
		private set
		{
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x22324B0", Offset = "0x22325B1", VA = "0x22324B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x22325E0", Offset = "0x22326E1", VA = "0x22325E0")]
	public void AddIgnore(Collider collider)
	{
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x2232650", Offset = "0x2232751", VA = "0x2232650")]
	public void RemoveIgnore(Collider collider)
	{
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x22326C0", Offset = "0x22327C1", VA = "0x22326C0")]
	public void DoUpdate()
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x22334C0", Offset = "0x22335C1", VA = "0x22334C0")]
	public InteractionInterface GetInteraction()
	{
		return null;
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x222B640", Offset = "0x222B741", VA = "0x222B640")]
	public ItemInteractionInterface GetItemInteraction()
	{
		return null;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x2233630", Offset = "0x2233731", VA = "0x2233630")]
	public SlashInteractionInterface GetSlashInteraction()
	{
		return null;
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x22337A0", Offset = "0x22338A1", VA = "0x22337A0")]
	public SmashInteractionInterface GetSmashInteraction()
	{
		return null;
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x2233910", Offset = "0x2233A11", VA = "0x2233910")]
	public PlowInteractionInterface GetPlowInteraction()
	{
		return null;
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x2233A80", Offset = "0x2233B81", VA = "0x2233A80")]
	public SowInteractionInterface GetSowInteraction()
	{
		return null;
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x2233BF0", Offset = "0x2233CF1", VA = "0x2233BF0")]
	public PotInteractionInterface GetPotInteraction()
	{
		return null;
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x2233D60", Offset = "0x2233E61", VA = "0x2233D60")]
	public ChopInteractionInterface GetChopInteraction()
	{
		return null;
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00006B40 File Offset: 0x00004D40
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x2233ED0", Offset = "0x2233FD1", VA = "0x2233ED0")]
	public bool CanInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00006B58 File Offset: 0x00004D58
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x2233FB0", Offset = "0x22340B1", VA = "0x2233FB0")]
	public bool CanInteraction(MonsterControllerBase monsterController)
	{
		return default(bool);
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00006B70 File Offset: 0x00004D70
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x2234090", Offset = "0x2234191", VA = "0x2234090")]
	public bool CanItemInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00006B88 File Offset: 0x00004D88
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x22341A0", Offset = "0x22342A1", VA = "0x22341A0")]
	public bool CanRapidItemInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x22342A0", Offset = "0x22343A1", VA = "0x22342A0")]
	public bool CanSlashInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x2234380", Offset = "0x2234481", VA = "0x2234380")]
	public bool CanSmashInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x2234460", Offset = "0x2234561", VA = "0x2234460")]
	public bool CanBreakInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x2234540", Offset = "0x2234641", VA = "0x2234540")]
	public bool CanPlowInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x2234620", Offset = "0x2234721", VA = "0x2234620")]
	public bool CanChopInteraction(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x2234700", Offset = "0x2234801", VA = "0x2234700")]
	public InteractionCollider()
	{
	}

	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_AllowAngle;

	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve m_AnglePriority;

	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent OnChangeCurrentInteraction;

	// Token: 0x040008B9 RID: 2233
	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Collider> m_IgnoreList;

	// Token: 0x040008BA RID: 2234
	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x58")]
	private FocusInterface _CurrentFocus;

	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E690", Offset = "0x15E791")]
	private Collider <CurrentFocusCollider>k__BackingField;

	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40006EA")]
	protected const int FocusBufferMaxSize = 128;

	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x15E6A0", Offset = "0x15E7A1")]
	private ValueTuple<Collider, FocusInterface, Vector3, float>[] m_WorkList;

	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x70")]
	protected Dictionary<Collider, FocusInterface> m_FocusList;

	// Token: 0x040008BF RID: 2239
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x0")]
	private static InteractionCollider.PriorityComparer m_PriorityComparer;

	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2001006")]
	private class PriorityComparer : IComparer<ValueTuple<Collider, FocusInterface, Vector3, float>>
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6006C6E")]
		[Address(RVA = "0x2234990", Offset = "0x2234A91", VA = "0x2234990", Slot = "4")]
		public int Compare([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B7F90", Offset = "0x1B8091")] ValueTuple<Collider, FocusInterface, Vector3, float> a, [Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B8070", Offset = "0x1B8171")] ValueTuple<Collider, FocusInterface, Vector3, float> b)
		{
			return 0;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6F")]
		[Address(RVA = "0x2234980", Offset = "0x2234A81", VA = "0x2234980")]
		public PriorityComparer()
		{
		}
	}
}
