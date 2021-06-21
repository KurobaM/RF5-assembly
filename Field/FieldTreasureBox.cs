using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200112E RID: 4398
	[Token(Token = "0x2000B10")]
	public class FieldTreasureBox : CharacterBase, InteractionInterface, FocusInterface
	{
		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x00026448 File Offset: 0x00024648
		// (set) Token: 0x06006F39 RID: 28473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B08")]
		public int ID
		{
			[Token(Token = "0x6005C32")]
			[Address(RVA = "0x1F8A790", Offset = "0x1F8A891", VA = "0x1F8A790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFD0", Offset = "0x1AF0D1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005C33")]
			[Address(RVA = "0x1F8A7A0", Offset = "0x1F8A8A1", VA = "0x1F8A7A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFE0", Offset = "0x1AF0E1")]
			set
			{
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x00026460 File Offset: 0x00024660
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B09")]
		public FieldTreasureBoxDataType TreasureBoxType
		{
			[Token(Token = "0x6005C34")]
			[Address(RVA = "0x1F8A7B0", Offset = "0x1F8A8B1", VA = "0x1F8A7B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFF0", Offset = "0x1AF0F1")]
			get
			{
				return FieldTreasureBoxDataType.None;
			}
			[Token(Token = "0x6005C35")]
			[Address(RVA = "0x1F8A7C0", Offset = "0x1F8A8C1", VA = "0x1F8A7C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF000", Offset = "0x1AF101")]
			set
			{
			}
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x00026478 File Offset: 0x00024678
		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x1F88330", Offset = "0x1F88431", VA = "0x1F88330")]
		public bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x1F8A7D0", Offset = "0x1F8A8D1", VA = "0x1F8A7D0", Slot = "11")]
		protected override void Awake()
		{
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x1F87DE0", Offset = "0x1F87EE1", VA = "0x1F87DE0")]
		public void SetBoxData(FieldTreasureBoxData boxData)
		{
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x1F8A8C0", Offset = "0x1F8A9C1", VA = "0x1F8A8C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x1F8AB60", Offset = "0x1F8AC61", VA = "0x1F8AB60", Slot = "30")]
		public virtual void SetDataTableID(int id, FieldTreasureBoxDataType type)
		{
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x1F87810", Offset = "0x1F87911", VA = "0x1F87810")]
		public void BoxReset()
		{
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x1F8AB70", Offset = "0x1F8AC71", VA = "0x1F8AB70", Slot = "31")]
		public virtual void DoInteraction(HumanController character)
		{
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x1F8ACF0", Offset = "0x1F8ADF1", VA = "0x1F8ACF0")]
		protected void OpenTreasureBox()
		{
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x1F8B630", Offset = "0x1F8B731", VA = "0x1F8B630")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF010", Offset = "0x1AF111")]
		protected IEnumerator GetRecipeAdvScript(FieldTreasureBoxDropRecipe[] recipeDatas)
		{
			return null;
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x1F8B5B0", Offset = "0x1F8B6B1", VA = "0x1F8B5B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF080", Offset = "0x1AF181")]
		protected IEnumerator FadeClearModel()
		{
			return null;
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06006F46 RID: 28486 RVA: 0x00026490 File Offset: 0x00024690
		[Token(Token = "0x17000B0A")]
		public bool Focusable
		{
			[Token(Token = "0x6005C40")]
			[Address(RVA = "0x1F8B730", Offset = "0x1F8B831", VA = "0x1F8B730", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x000264A8 File Offset: 0x000246A8
		[Token(Token = "0x17000B0B")]
		public FocusObjectType FocusObjectType
		{
			[Token(Token = "0x6005C41")]
			[Address(RVA = "0x1F8B770", Offset = "0x1F8B871", VA = "0x1F8B770", Slot = "24")]
			get
			{
				return FocusObjectType.Default;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x000264C0 File Offset: 0x000246C0
		[Token(Token = "0x17000B0C")]
		public int FocusPriority
		{
			[Token(Token = "0x6005C42")]
			[Address(RVA = "0x1F8B780", Offset = "0x1F8B881", VA = "0x1F8B780", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x000264D8 File Offset: 0x000246D8
		[Token(Token = "0x17000B0D")]
		public FocusPointType FocusPointType
		{
			[Token(Token = "0x6005C43")]
			[Address(RVA = "0x1F8B790", Offset = "0x1F8B891", VA = "0x1F8B790", Slot = "26")]
			get
			{
				return FocusPointType.HitPoint;
			}
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x000264F0 File Offset: 0x000246F0
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x1F8B7A0", Offset = "0x1F8B8A1", VA = "0x1F8B7A0", Slot = "16")]
		public bool CanInteraction(HumanController character)
		{
			return default(bool);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x1F8B840", Offset = "0x1F8B941", VA = "0x1F8B840", Slot = "20")]
		public string GetFocusName()
		{
			return null;
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x1F8B850", Offset = "0x1F8B951", VA = "0x1F8B850", Slot = "19")]
		public string GetInteractionButtonHint()
		{
			return null;
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x1F8B8A0", Offset = "0x1F8B9A1", VA = "0x1F8B8A0", Slot = "23")]
		public void OffFocus()
		{
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x1F8B8B0", Offset = "0x1F8B9B1", VA = "0x1F8B8B0", Slot = "22")]
		public void OnFocus()
		{
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x00026508 File Offset: 0x00024708
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x1F8B8C0", Offset = "0x1F8B9C1", VA = "0x1F8B8C0", Slot = "27")]
		public ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x1F8B9A0", Offset = "0x1F8BAA1", VA = "0x1F8B9A0")]
		protected void OnDrawGizmos()
		{
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x00026520 File Offset: 0x00024720
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x1F8BAC0", Offset = "0x1F8BBC1", VA = "0x1F8BAC0", Slot = "7")]
		public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
		{
			return default(bool);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x1F8BCC0", Offset = "0x1F8BDC1", VA = "0x1F8BCC0", Slot = "17")]
		public void DoInteraction(MonsterControllerBase character)
		{
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x00026538 File Offset: 0x00024738
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x1F8BCD0", Offset = "0x1F8BDD1", VA = "0x1F8BCD0", Slot = "18")]
		public bool CanInteraction(MonsterControllerBase character)
		{
			return default(bool);
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x1F8BCE0", Offset = "0x1F8BDE1", VA = "0x1F8BCE0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x1F8BE70", Offset = "0x1F8BF71", VA = "0x1F8BE70")]
		public FieldTreasureBox()
		{
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x1F8BF20", Offset = "0x1F8C021", VA = "0x1F8BF20", Slot = "28")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x1F8BF30", Offset = "0x1F8C031", VA = "0x1F8BF30", Slot = "29")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04018212 RID: 98834
		[Token(Token = "0x4014CAB")]
		private const string FoucsNameTextID = "FIELD_LAYOUT_OBJECT_NAME_00001";

		// Token: 0x04018213 RID: 98835
		[Token(Token = "0x4014CAC")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181590", Offset = "0x181691")]
		private int <ID>k__BackingField;

		// Token: 0x04018214 RID: 98836
		[Token(Token = "0x4014CAD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1815A0", Offset = "0x1816A1")]
		private FieldTreasureBoxDataType <TreasureBoxType>k__BackingField;

		// Token: 0x04018215 RID: 98837
		[Token(Token = "0x4014CAE")]
		[FieldOffset(Offset = "0x70")]
		protected FieldTreasureBoxData BoxData;

		// Token: 0x04018216 RID: 98838
		[Token(Token = "0x4014CAF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Transform[] DropPoints;

		// Token: 0x04018217 RID: 98839
		[Token(Token = "0x4014CB0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Transform DropStartPoint;

		// Token: 0x04018218 RID: 98840
		[Token(Token = "0x4014CB1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected float SmokeEffectHeight;

		// Token: 0x04018219 RID: 98841
		[Token(Token = "0x4014CB2")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		protected float SmokeEffectLength;

		// Token: 0x0401821A RID: 98842
		[Token(Token = "0x4014CB3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3 TreasureSmokeOffset;

		// Token: 0x0401821B RID: 98843
		[Token(Token = "0x4014CB4")]
		[FieldOffset(Offset = "0x90")]
		protected GameObject Model;

		// Token: 0x0401821C RID: 98844
		[Token(Token = "0x4014CB5")]
		[FieldOffset(Offset = "0x98")]
		protected string FocusName;

		// Token: 0x0401821D RID: 98845
		[Token(Token = "0x4014CB6")]
		[FieldOffset(Offset = "0xA0")]
		protected bool DoneInteraction;

		// Token: 0x0401821E RID: 98846
		[Token(Token = "0x4014CB7")]
		[FieldOffset(Offset = "0xA1")]
		protected bool IsBroken;

		// Token: 0x0401821F RID: 98847
		[Token(Token = "0x4014CB8")]
		[FieldOffset(Offset = "0xA2")]
		protected bool IsAdvWait;

		// Token: 0x04018220 RID: 98848
		[Token(Token = "0x4014CB9")]
		[FieldOffset(Offset = "0xA4")]
		private float CurrentTime;

		// Token: 0x0200112F RID: 4399
		[Token(Token = "0x200158A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A220", Offset = "0x15A321")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06006F59 RID: 28505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB5")]
			[Address(RVA = "0x1F8BF40", Offset = "0x1F8C041", VA = "0x1F8BF40")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06006F5A RID: 28506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB6")]
			[Address(RVA = "0x1F8BF50", Offset = "0x1F8C051", VA = "0x1F8BF50")]
			internal void <GetRecipeAdvScript>b__0()
			{
			}

			// Token: 0x06006F5B RID: 28507 RVA: 0x00026550 File Offset: 0x00024750
			[Token(Token = "0x6007DB7")]
			[Address(RVA = "0x1F8BF60", Offset = "0x1F8C061", VA = "0x1F8BF60")]
			internal bool <GetRecipeAdvScript>b__1()
			{
				return default(bool);
			}

			// Token: 0x04018221 RID: 98849
			[Token(Token = "0x401C173")]
			[FieldOffset(Offset = "0x10")]
			public bool isAdvEndWait;
		}

		// Token: 0x02001130 RID: 4400
		[Token(Token = "0x200158B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A230", Offset = "0x15A331")]
		private sealed class <GetRecipeAdvScript>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006F5C RID: 28508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB8")]
			[Address(RVA = "0x1F8B6D0", Offset = "0x1F8B7D1", VA = "0x1F8B6D0")]
			[DebuggerHidden]
			public <GetRecipeAdvScript>d__28(int <>1__state)
			{
			}

			// Token: 0x06006F5D RID: 28509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB9")]
			[Address(RVA = "0x1F8C460", Offset = "0x1F8C561", VA = "0x1F8C460", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006F5E RID: 28510 RVA: 0x00026568 File Offset: 0x00024768
			[Token(Token = "0x6007DBA")]
			[Address(RVA = "0x1F8C470", Offset = "0x1F8C571", VA = "0x1F8C470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x06006F5F RID: 28511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED3")]
			private object Current
			{
				[Token(Token = "0x6007DBB")]
				[Address(RVA = "0x1F8C800", Offset = "0x1F8C901", VA = "0x1F8C800", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006F60 RID: 28512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBC")]
			[Address(RVA = "0x1F8C810", Offset = "0x1F8C911", VA = "0x1F8C810", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x06006F61 RID: 28513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED4")]
			private object Current
			{
				[Token(Token = "0x6007DBD")]
				[Address(RVA = "0x1F8C870", Offset = "0x1F8C971", VA = "0x1F8C870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018222 RID: 98850
			[Token(Token = "0x401C174")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018223 RID: 98851
			[Token(Token = "0x401C175")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018224 RID: 98852
			[Token(Token = "0x401C176")]
			[FieldOffset(Offset = "0x20")]
			public FieldTreasureBoxDropRecipe[] recipeDatas;

			// Token: 0x04018225 RID: 98853
			[Token(Token = "0x401C177")]
			[FieldOffset(Offset = "0x28")]
			public FieldTreasureBox <>4__this;

			// Token: 0x04018226 RID: 98854
			[Token(Token = "0x401C178")]
			[FieldOffset(Offset = "0x30")]
			private int <i>5__2;
		}

		// Token: 0x02001131 RID: 4401
		[Token(Token = "0x200158C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A240", Offset = "0x15A341")]
		private sealed class <FadeClearModel>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006F62 RID: 28514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBE")]
			[Address(RVA = "0x1F8B700", Offset = "0x1F8B801", VA = "0x1F8B700")]
			[DebuggerHidden]
			public <FadeClearModel>d__30(int <>1__state)
			{
			}

			// Token: 0x06006F63 RID: 28515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBF")]
			[Address(RVA = "0x1F8BF70", Offset = "0x1F8C071", VA = "0x1F8BF70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006F64 RID: 28516 RVA: 0x00026580 File Offset: 0x00024780
			[Token(Token = "0x6007DC0")]
			[Address(RVA = "0x1F8BF80", Offset = "0x1F8C081", VA = "0x1F8BF80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x06006F65 RID: 28517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED5")]
			private object Current
			{
				[Token(Token = "0x6007DC1")]
				[Address(RVA = "0x1F8C3E0", Offset = "0x1F8C4E1", VA = "0x1F8C3E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006F66 RID: 28518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC2")]
			[Address(RVA = "0x1F8C3F0", Offset = "0x1F8C4F1", VA = "0x1F8C3F0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x06006F67 RID: 28519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED6")]
			private object Current
			{
				[Token(Token = "0x6007DC3")]
				[Address(RVA = "0x1F8C450", Offset = "0x1F8C551", VA = "0x1F8C450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018227 RID: 98855
			[Token(Token = "0x401C179")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018228 RID: 98856
			[Token(Token = "0x401C17A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018229 RID: 98857
			[Token(Token = "0x401C17B")]
			[FieldOffset(Offset = "0x20")]
			public FieldTreasureBox <>4__this;

			// Token: 0x0401822A RID: 98858
			[Token(Token = "0x401C17C")]
			[FieldOffset(Offset = "0x28")]
			private MaterialPropertyBlock <materialPropertyBlock>5__2;

			// Token: 0x0401822B RID: 98859
			[Token(Token = "0x401C17D")]
			[FieldOffset(Offset = "0x30")]
			private Renderer <renderer>5__3;
		}
	}
}
