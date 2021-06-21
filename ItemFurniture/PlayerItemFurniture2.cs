using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001051 RID: 4177
	[Token(Token = "0x2000A9B")]
	public class PlayerItemFurniture2 : MonoBehaviour, HoldableInterface, InteractionInterface, FocusInterface
	{
		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600691F RID: 26911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A85")]
		public Renderer[] ModelMeshes
		{
			[Token(Token = "0x6005790")]
			[Address(RVA = "0x20823A0", Offset = "0x20824A1", VA = "0x20823A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD390", Offset = "0x1AD491")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005791")]
			[Address(RVA = "0x20823B0", Offset = "0x20824B1", VA = "0x20823B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3A0", Offset = "0x1AD4A1")]
			private set
			{
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x00023EF8 File Offset: 0x000220F8
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A86")]
		public bool IsDispModel
		{
			[Token(Token = "0x6005792")]
			[Address(RVA = "0x20823C0", Offset = "0x20824C1", VA = "0x20823C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3B0", Offset = "0x1AD4B1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005793")]
			[Address(RVA = "0x20823D0", Offset = "0x20824D1", VA = "0x20823D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3C0", Offset = "0x1AD4C1")]
			set
			{
			}
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005794")]
		[Address(RVA = "0x20823E0", Offset = "0x20824E1", VA = "0x20823E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005795")]
		[Address(RVA = "0x2076E30", Offset = "0x2076F31", VA = "0x2076E30")]
		public void Break(bool is_remove, bool del_savedata = true)
		{
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005796")]
		[Address(RVA = "0x20824E0", Offset = "0x20825E1", VA = "0x20824E0")]
		private void CreateItem(ItemID itemID)
		{
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x00023F10 File Offset: 0x00022110
		[Token(Token = "0x17000A87")]
		public HoldMotionType HoldMotionType
		{
			[Token(Token = "0x6005797")]
			[Address(RVA = "0x20825D0", Offset = "0x20826D1", VA = "0x20825D0", Slot = "11")]
			get
			{
				return HoldMotionType.Head;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A88")]
		public ItemData ItemData
		{
			[Token(Token = "0x6005798")]
			[Address(RVA = "0x20825E0", Offset = "0x20826E1", VA = "0x20825E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06006927 RID: 26919 RVA: 0x00023F28 File Offset: 0x00022128
		[Token(Token = "0x17000A89")]
		public bool Focusable
		{
			[Token(Token = "0x6005799")]
			[Address(RVA = "0x207EA50", Offset = "0x207EB51", VA = "0x207EA50", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x00023F40 File Offset: 0x00022140
		[Token(Token = "0x17000A8A")]
		public FocusObjectType FocusObjectType
		{
			[Token(Token = "0x600579A")]
			[Address(RVA = "0x20825F0", Offset = "0x20826F1", VA = "0x20825F0", Slot = "26")]
			get
			{
				return FocusObjectType.Default;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06006929 RID: 26921 RVA: 0x00023F58 File Offset: 0x00022158
		[Token(Token = "0x17000A8B")]
		public int FocusPriority
		{
			[Token(Token = "0x600579B")]
			[Address(RVA = "0x2082600", Offset = "0x2082701", VA = "0x2082600", Slot = "27")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x00023F70 File Offset: 0x00022170
		[Token(Token = "0x17000A8C")]
		public FocusPointType FocusPointType
		{
			[Token(Token = "0x600579C")]
			[Address(RVA = "0x2082610", Offset = "0x2082711", VA = "0x2082610", Slot = "28")]
			get
			{
				return FocusPointType.HitPoint;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8D")]
		public ThrowController ThrowController
		{
			[Token(Token = "0x600579D")]
			[Address(RVA = "0x2082620", Offset = "0x2082721", VA = "0x2082620", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579E")]
		[Address(RVA = "0x2082630", Offset = "0x2082731", VA = "0x2082630")]
		private void Awake()
		{
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579F")]
		[Address(RVA = "0x207FD20", Offset = "0x207FE21", VA = "0x207FD20")]
		public void SetHp(int hp)
		{
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x2082A70", Offset = "0x2082B71", VA = "0x2082A70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x2082B20", Offset = "0x2082C21", VA = "0x2082B20")]
		private void OnEnable()
		{
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x2082BD0", Offset = "0x2082CD1", VA = "0x2082BD0")]
		private void Update()
		{
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x20830E0", Offset = "0x20831E1", VA = "0x20830E0", Slot = "4")]
		public void OnHold()
		{
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x20832E0", Offset = "0x20833E1", VA = "0x20832E0", Slot = "5")]
		public void OnPutOn()
		{
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00023F88 File Offset: 0x00022188
		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x2083470", Offset = "0x2083571", VA = "0x2083470", Slot = "7")]
		public bool CanThrow()
		{
			return default(bool);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A6")]
		[Address(RVA = "0x2083480", Offset = "0x2083581", VA = "0x2083480")]
		public void Throw(Quaternion direction)
		{
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A7")]
		[Address(RVA = "0x2083490", Offset = "0x2083591", VA = "0x2083490", Slot = "17")]
		public void DoInteraction(HumanController character)
		{
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A8")]
		[Address(RVA = "0x207C310", Offset = "0x207C411", VA = "0x207C310")]
		public void PickUp()
		{
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x207F4B0", Offset = "0x207F5B1", VA = "0x207F4B0")]
		public void Have()
		{
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00023FA0 File Offset: 0x000221A0
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x20835A0", Offset = "0x20836A1", VA = "0x20835A0", Slot = "18")]
		public bool CanInteraction(HumanController character)
		{
			return default(bool);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x2083610", Offset = "0x2083711", VA = "0x2083610", Slot = "21")]
		public string GetInteractionButtonHint()
		{
			return null;
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x2083660", Offset = "0x2083761", VA = "0x2083660", Slot = "22")]
		public string GetFocusName()
		{
			return null;
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x2083670", Offset = "0x2083771", VA = "0x2083670", Slot = "24")]
		public void OnFocus()
		{
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x2083680", Offset = "0x2083781", VA = "0x2083680", Slot = "25")]
		public void OffFocus()
		{
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00023FB8 File Offset: 0x000221B8
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x2083690", Offset = "0x2083791", VA = "0x2083690", Slot = "32")]
		public virtual ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00023FD0 File Offset: 0x000221D0
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x2083740", Offset = "0x2083841", VA = "0x2083740", Slot = "15")]
		public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID)
		{
			return ButtonInteractType.None;
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00023FE8 File Offset: 0x000221E8
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x2083780", Offset = "0x2083881", VA = "0x2083780", Slot = "12")]
		public bool CanPuton()
		{
			return default(bool);
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00024000 File Offset: 0x00022200
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0x20837C0", Offset = "0x20838C1", VA = "0x20837C0", Slot = "13")]
		public bool CanRuckIn()
		{
			return default(bool);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00024018 File Offset: 0x00022218
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x20837D0", Offset = "0x20838D1", VA = "0x20837D0", Slot = "14")]
		public bool OnTakeDamage(DamageResult result)
		{
			return default(bool);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0x2083920", Offset = "0x2083A21", VA = "0x2083920")]
		public void OnThrow(Quaternion direction)
		{
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0x2083930", Offset = "0x2083A31", VA = "0x2083930", Slot = "8")]
		public void OnThrow()
		{
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0x2083940", Offset = "0x2083A41", VA = "0x2083940")]
		public void HitCheck(Collider collider)
		{
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x2083950", Offset = "0x2083A51", VA = "0x2083950", Slot = "10")]
		public void OnPutOnByThrow()
		{
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00024030 File Offset: 0x00022230
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0x2083960", Offset = "0x2083A61", VA = "0x2083960", Slot = "9")]
		public bool HitCheck(HitResult result, ThrowController throwController)
		{
			return default(bool);
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0x2083970", Offset = "0x2083A71", VA = "0x2083970", Slot = "19")]
		public void DoInteraction(MonsterControllerBase character)
		{
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00024048 File Offset: 0x00022248
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0x2083980", Offset = "0x2083A81", VA = "0x2083980", Slot = "20")]
		public bool CanInteraction(MonsterControllerBase character)
		{
			return default(bool);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0x2083460", Offset = "0x2083561", VA = "0x2083460", Slot = "16")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BC")]
		[Address(RVA = "0x2083990", Offset = "0x2083A91", VA = "0x2083990")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BD")]
		[Address(RVA = "0x20828F0", Offset = "0x20829F1", VA = "0x20828F0")]
		private void SetTrigger(bool enable)
		{
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0x20829B0", Offset = "0x2082AB1", VA = "0x20829B0")]
		private void SetEnable(bool enable)
		{
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BF")]
		[Address(RVA = "0x2083230", Offset = "0x2083331", VA = "0x2083230")]
		private void OnCollider()
		{
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x2083B90", Offset = "0x2083C91", VA = "0x2083B90")]
		public PlayerItemFurniture2()
		{
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x2083C40", Offset = "0x2083D41", VA = "0x2083C40", Slot = "30")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x2083C50", Offset = "0x2083D51", VA = "0x2083C50", Slot = "31")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04017147 RID: 94535
		[Token(Token = "0x4013DAD")]
		[FieldOffset(Offset = "0x18")]
		public FurnitureID FurnitureID;

		// Token: 0x04017148 RID: 94536
		[Token(Token = "0x4013DAE")]
		[FieldOffset(Offset = "0x20")]
		public string UniqueID;

		// Token: 0x04017149 RID: 94537
		[Token(Token = "0x4013DAF")]
		[FieldOffset(Offset = "0x28")]
		public int Hp;

		// Token: 0x0401714A RID: 94538
		[Token(Token = "0x4013DB0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HideInInspector", RVA = "0x1806A0", Offset = "0x1807A1")]
		public bool LoadCreate;

		// Token: 0x0401714B RID: 94539
		[Token(Token = "0x4013DB1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HideInInspector", RVA = "0x1806B0", Offset = "0x1807B1")]
		public int PrefabId;

		// Token: 0x0401714C RID: 94540
		[Token(Token = "0x4013DB2")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "HideInInspector", RVA = "0x1806C0", Offset = "0x1807C1")]
		public Vector3 ShadowPos;

		// Token: 0x0401714D RID: 94541
		[Token(Token = "0x4013DB3")]
		[FieldOffset(Offset = "0x40")]
		private FurnitureShadow furnitureShadow;

		// Token: 0x0401714E RID: 94542
		[Token(Token = "0x4013DB4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1806D0", Offset = "0x1807D1")]
		private Renderer[] <ModelMeshes>k__BackingField;

		// Token: 0x0401714F RID: 94543
		[Token(Token = "0x4013DB5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1806E0", Offset = "0x1807E1")]
		private bool <IsDispModel>k__BackingField;

		// Token: 0x04017150 RID: 94544
		[Token(Token = "0x4013DB6")]
		[FieldOffset(Offset = "0x51")]
		private bool isRemove;

		// Token: 0x04017151 RID: 94545
		[Token(Token = "0x4013DB7")]
		[FieldOffset(Offset = "0x54")]
		private PlayerItemFurniture2.State CurrentState;

		// Token: 0x04017152 RID: 94546
		[Token(Token = "0x4013DB8")]
		[FieldOffset(Offset = "0x58")]
		private Collider Collider;

		// Token: 0x04017153 RID: 94547
		[Token(Token = "0x4013DB9")]
		[FieldOffset(Offset = "0x60")]
		private MeshCollider MeshCollider;

		// Token: 0x04017154 RID: 94548
		[Token(Token = "0x4013DBA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FurnitureBreakConditions furnitureBreakConditions;

		// Token: 0x02001052 RID: 4178
		[Token(Token = "0x2001522")]
		private enum State
		{
			// Token: 0x04017156 RID: 94550
			[Token(Token = "0x401BFA7")]
			Ground,
			// Token: 0x04017157 RID: 94551
			[Token(Token = "0x401BFA8")]
			Hold
		}
	}
}
