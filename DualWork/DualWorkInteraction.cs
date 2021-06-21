using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace DualWork
{
	// Token: 0x020010BC RID: 4284
	[Token(Token = "0x2000ABE")]
	public class DualWorkInteraction : MonoBehaviour, InteractionInterface, FocusInterface
	{
		// Token: 0x06006CA7 RID: 27815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0x1E065A0", Offset = "0x1E066A1", VA = "0x1E065A0")]
		private void Awake()
		{
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x000255C0 File Offset: 0x000237C0
		[Token(Token = "0x17000ACC")]
		public bool Focusable
		{
			[Token(Token = "0x6005A1E")]
			[Address(RVA = "0x1E066F0", Offset = "0x1E067F1", VA = "0x1E066F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x000255D8 File Offset: 0x000237D8
		[Token(Token = "0x17000ACD")]
		public FocusObjectType FocusObjectType
		{
			[Token(Token = "0x6005A1F")]
			[Address(RVA = "0x1E06780", Offset = "0x1E06881", VA = "0x1E06780", Slot = "13")]
			get
			{
				return FocusObjectType.Default;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06006CAA RID: 27818 RVA: 0x000255F0 File Offset: 0x000237F0
		[Token(Token = "0x17000ACE")]
		public int FocusPriority
		{
			[Token(Token = "0x6005A20")]
			[Address(RVA = "0x1E06790", Offset = "0x1E06891", VA = "0x1E06790", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x00025608 File Offset: 0x00023808
		[Token(Token = "0x17000ACF")]
		public FocusPointType FocusPointType
		{
			[Token(Token = "0x6005A21")]
			[Address(RVA = "0x1E067A0", Offset = "0x1E068A1", VA = "0x1E067A0", Slot = "15")]
			get
			{
				return FocusPointType.HitPoint;
			}
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00025620 File Offset: 0x00023820
		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x1E067B0", Offset = "0x1E068B1", VA = "0x1E067B0", Slot = "5")]
		public bool CanInteraction(HumanController character)
		{
			return default(bool);
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x1E067C0", Offset = "0x1E068C1", VA = "0x1E067C0", Slot = "4")]
		public void DoInteraction(HumanController character)
		{
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x1E06B00", Offset = "0x1E06C01", VA = "0x1E06B00", Slot = "9")]
		public string GetFocusName()
		{
			return null;
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x1E06C00", Offset = "0x1E06D01", VA = "0x1E06C00", Slot = "8")]
		public string GetInteractionButtonHint()
		{
			return null;
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x1E06C50", Offset = "0x1E06D51", VA = "0x1E06C50", Slot = "12")]
		public void OffFocus()
		{
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x1E06C60", Offset = "0x1E06D61", VA = "0x1E06C60", Slot = "11")]
		public void OnFocus()
		{
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00025638 File Offset: 0x00023838
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x1E06C70", Offset = "0x1E06D71", VA = "0x1E06C70", Slot = "16")]
		public ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x1E06CE0", Offset = "0x1E06DE1", VA = "0x1E06CE0")]
		public void Reset()
		{
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x1E06DA0", Offset = "0x1E06EA1", VA = "0x1E06DA0", Slot = "6")]
		public void DoInteraction(MonsterControllerBase character)
		{
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00025650 File Offset: 0x00023850
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x1E06DB0", Offset = "0x1E06EB1", VA = "0x1E06DB0", Slot = "7")]
		public bool CanInteraction(MonsterControllerBase character)
		{
			return default(bool);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x1E06DC0", Offset = "0x1E06EC1", VA = "0x1E06DC0")]
		public DualWorkInteraction()
		{
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x1E06DD0", Offset = "0x1E06ED1", VA = "0x1E06DD0", Slot = "17")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x1E06DE0", Offset = "0x1E06EE1", VA = "0x1E06DE0", Slot = "18")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x040174CB RID: 95435
		[Token(Token = "0x4013FD7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DualWorkObject DualWorkObject;

		// Token: 0x040174CC RID: 95436
		[Token(Token = "0x4013FD8")]
		[FieldOffset(Offset = "0x20")]
		private string FocusNameBySystemTextID;
	}
}
