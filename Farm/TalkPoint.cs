using System;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

namespace Farm
{
	// Token: 0x020010B8 RID: 4280
	[Token(Token = "0x2000ABC")]
	public class TalkPoint : MonoBehaviour, InteractionInterface, FocusInterface
	{
		// Token: 0x06006C4B RID: 27723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x21A5330", Offset = "0x21A5431", VA = "0x21A5330", Slot = "9")]
		public string GetFocusName()
		{
			return null;
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x00025158 File Offset: 0x00023358
		[Token(Token = "0x17000AC8")]
		public bool Focusable
		{
			[Token(Token = "0x60059D9")]
			[Address(RVA = "0x21A5590", Offset = "0x21A5691", VA = "0x21A5590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0x21A55A0", Offset = "0x21A56A1", VA = "0x21A55A0", Slot = "11")]
		public void OnFocus()
		{
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x21A55B0", Offset = "0x21A56B1", VA = "0x21A55B0", Slot = "12")]
		public void OffFocus()
		{
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06006C4F RID: 27727 RVA: 0x00025170 File Offset: 0x00023370
		[Token(Token = "0x17000AC9")]
		public FocusObjectType FocusObjectType
		{
			[Token(Token = "0x60059DC")]
			[Address(RVA = "0x21A55C0", Offset = "0x21A56C1", VA = "0x21A55C0", Slot = "13")]
			get
			{
				return FocusObjectType.Default;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06006C50 RID: 27728 RVA: 0x00025188 File Offset: 0x00023388
		[Token(Token = "0x17000ACA")]
		public int FocusPriority
		{
			[Token(Token = "0x60059DD")]
			[Address(RVA = "0x21A55D0", Offset = "0x21A56D1", VA = "0x21A55D0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x000251A0 File Offset: 0x000233A0
		[Token(Token = "0x17000ACB")]
		public FocusPointType FocusPointType
		{
			[Token(Token = "0x60059DE")]
			[Address(RVA = "0x21A55E0", Offset = "0x21A56E1", VA = "0x21A55E0", Slot = "15")]
			get
			{
				return FocusPointType.HitPoint;
			}
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x000251B8 File Offset: 0x000233B8
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x21A55F0", Offset = "0x21A56F1", VA = "0x21A55F0", Slot = "16")]
		public ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x21A5600", Offset = "0x21A5701", VA = "0x21A5600", Slot = "4")]
		public void DoInteraction(HumanController character)
		{
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x000251D0 File Offset: 0x000233D0
		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x21A5850", Offset = "0x21A5951", VA = "0x21A5850", Slot = "5")]
		public bool CanInteraction(HumanController character)
		{
			return default(bool);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x21A5860", Offset = "0x21A5961", VA = "0x21A5860", Slot = "8")]
		public string GetInteractionButtonHint()
		{
			return null;
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x21A5610", Offset = "0x21A5711", VA = "0x21A5610")]
		private void talk2Dragon()
		{
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0x21A58C0", Offset = "0x21A59C1", VA = "0x21A58C0", Slot = "6")]
		public void DoInteraction(MonsterControllerBase character)
		{
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x000251E8 File Offset: 0x000233E8
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0x21A58D0", Offset = "0x21A59D1", VA = "0x21A58D0", Slot = "7")]
		public bool CanInteraction(MonsterControllerBase character)
		{
			return default(bool);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0x21A58E0", Offset = "0x21A59E1", VA = "0x21A58E0")]
		private void Update()
		{
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x21A5C00", Offset = "0x21A5D01", VA = "0x21A5C00")]
		public TalkPoint()
		{
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x21A5C60", Offset = "0x21A5D61", VA = "0x21A5C60", Slot = "17")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x21A5C70", Offset = "0x21A5D71", VA = "0x21A5C70", Slot = "18")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059EA")]
		[Address(RVA = "0x21A5C80", Offset = "0x21A5D81", VA = "0x21A5C80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE470", Offset = "0x1AE571")]
		private void <Update>b__21_0(AssetHandle<GameObject> obj)
		{
		}

		// Token: 0x0401749B RID: 95387
		[Token(Token = "0x4013FC3")]
		[FieldOffset(Offset = "0x18")]
		public bool isTalking;

		// Token: 0x0401749C RID: 95388
		[Token(Token = "0x4013FC4")]
		[FieldOffset(Offset = "0x20")]
		private GameObject crystalCountDisplay;

		// Token: 0x0401749D RID: 95389
		[Token(Token = "0x4013FC5")]
		[FieldOffset(Offset = "0x28")]
		private string scriptName;

		// Token: 0x020010B9 RID: 4281
		[Token(Token = "0x2001568")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A030", Offset = "0x15A131")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06006C5E RID: 27742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D22")]
			[Address(RVA = "0x21A58B0", Offset = "0x21A59B1", VA = "0x21A58B0")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06006C5F RID: 27743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D23")]
			[Address(RVA = "0x21A5D80", Offset = "0x21A5E81", VA = "0x21A5D80")]
			internal void <talk2Dragon>b__0()
			{
			}

			// Token: 0x06006C60 RID: 27744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D24")]
			[Address(RVA = "0x21A5F40", Offset = "0x21A6041", VA = "0x21A5F40")]
			internal void <talk2Dragon>b__1()
			{
			}

			// Token: 0x0401749E RID: 95390
			[Token(Token = "0x401C0E4")]
			[FieldOffset(Offset = "0x10")]
			public int crystal01;

			// Token: 0x0401749F RID: 95391
			[Token(Token = "0x401C0E5")]
			[FieldOffset(Offset = "0x18")]
			public ItemStorage itemStorage;

			// Token: 0x040174A0 RID: 95392
			[Token(Token = "0x401C0E6")]
			[FieldOffset(Offset = "0x20")]
			public string farmId;

			// Token: 0x040174A1 RID: 95393
			[Token(Token = "0x401C0E7")]
			[FieldOffset(Offset = "0x28")]
			public int crystal02;

			// Token: 0x040174A2 RID: 95394
			[Token(Token = "0x401C0E8")]
			[FieldOffset(Offset = "0x2C")]
			public int crystal03;

			// Token: 0x040174A3 RID: 95395
			[Token(Token = "0x401C0E9")]
			[FieldOffset(Offset = "0x30")]
			public int crystal04;

			// Token: 0x040174A4 RID: 95396
			[Token(Token = "0x401C0EA")]
			[FieldOffset(Offset = "0x34")]
			public int crystal05;

			// Token: 0x040174A5 RID: 95397
			[Token(Token = "0x401C0EB")]
			[FieldOffset(Offset = "0x38")]
			public TalkPoint <>4__this;

			// Token: 0x040174A6 RID: 95398
			[Token(Token = "0x401C0EC")]
			[FieldOffset(Offset = "0x40")]
			public UnityAction <>9__1;
		}
	}
}
