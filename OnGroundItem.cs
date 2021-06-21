using System;
using System.Runtime.InteropServices;
using Define;
using Field;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000649 RID: 1609
[Token(Token = "0x2000485")]
public class OnGroundItem : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, HoldableInterface, PlowInteractionInterface, ToolInteractionInterface, SlashInteractionInterface, SmashInteractionInterface, ChopInteractionInterface
{
	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x060027BB RID: 10171 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000509")]
	public ItemData ItemData
	{
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x1F58C40", Offset = "0x1F58D41", VA = "0x1F58C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D60", Offset = "0x1A1E61")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x1F58C50", Offset = "0x1F58D51", VA = "0x1F58C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D70", Offset = "0x1A1E71")]
		private set
		{
		}
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x060027BD RID: 10173 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
	// (set) Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700050A")]
	public FieldItemSpawnID FieldItemSpawnID
	{
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x1F58C60", Offset = "0x1F58D61", VA = "0x1F58C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D80", Offset = "0x1A1E81")]
		get
		{
			return FieldItemSpawnID.EMPTY;
		}
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x1F58C70", Offset = "0x1F58D71", VA = "0x1F58C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D90", Offset = "0x1A1E91")]
		set
		{
		}
	}

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700050B")]
	public Transform Models
	{
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x1F58C80", Offset = "0x1F58D81", VA = "0x1F58C80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DA0", Offset = "0x1A1EA1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x1F58C90", Offset = "0x1F58D91", VA = "0x1F58C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DB0", Offset = "0x1A1EB1")]
		private set
		{
		}
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700050C")]
	public Renderer[] ModelsMeshes
	{
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x1F58CA0", Offset = "0x1F58DA1", VA = "0x1F58CA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DC0", Offset = "0x1A1EC1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x1F58CB0", Offset = "0x1F58DB1", VA = "0x1F58CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DD0", Offset = "0x1A1ED1")]
		private set
		{
		}
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x060027C3 RID: 10179 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
	// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700050D")]
	private bool IsEntry
	{
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x1F58CC0", Offset = "0x1F58DC1", VA = "0x1F58CC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DE0", Offset = "0x1A1EE1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x1F58CD0", Offset = "0x1F58DD1", VA = "0x1F58CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1DF0", Offset = "0x1A1EF1")]
		set
		{
		}
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002199")]
	[Address(RVA = "0x1F58CE0", Offset = "0x1F58DE1", VA = "0x1F58CE0")]
	public void OnNotPickup()
	{
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0000FC00 File Offset: 0x0000DE00
	// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700050E")]
	private bool IsHandCuffs
	{
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x1F58D70", Offset = "0x1F58E71", VA = "0x1F58D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E00", Offset = "0x1A1F01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x1F58D80", Offset = "0x1F58E81", VA = "0x1F58D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E10", Offset = "0x1A1F11")]
		set
		{
		}
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600219C")]
	[Address(RVA = "0x1F58D90", Offset = "0x1F58E91", VA = "0x1F58D90")]
	public void OnAnyPickup(ActorController pickupOwner, bool isHandCuffs)
	{
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219D")]
	[Address(RVA = "0x1F58E50", Offset = "0x1F58F51", VA = "0x1F58E50", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700050F")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x1F58EA0", Offset = "0x1F58FA1", VA = "0x1F58EA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219F")]
	[Address(RVA = "0x1F58EF0", Offset = "0x1F58FF1", VA = "0x1F58EF0", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x060027CC RID: 10188 RVA: 0x0000FC18 File Offset: 0x0000DE18
	[Token(Token = "0x17000510")]
	public bool Focusable
	{
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x1F58FF0", Offset = "0x1F590F1", VA = "0x1F58FF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x060027CD RID: 10189 RVA: 0x0000FC30 File Offset: 0x0000DE30
	[Token(Token = "0x17000511")]
	public bool CanPickup
	{
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x1F59070", Offset = "0x1F59171", VA = "0x1F59070")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x060027CE RID: 10190 RVA: 0x0000FC48 File Offset: 0x0000DE48
	[Token(Token = "0x17000512")]
	public HoldMotionType HoldMotionType
	{
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x1F590E0", Offset = "0x1F591E1", VA = "0x1F590E0", Slot = "29")]
		get
		{
			return HoldMotionType.Head;
		}
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x060027CF RID: 10191 RVA: 0x0000FC60 File Offset: 0x0000DE60
	// (set) Token: 0x060027D0 RID: 10192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000513")]
	public bool IsHide
	{
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x1F59110", Offset = "0x1F59211", VA = "0x1F59110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E20", Offset = "0x1A1F21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x1F59120", Offset = "0x1F59221", VA = "0x1F59120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E30", Offset = "0x1A1F31")]
		private set
		{
		}
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x060027D1 RID: 10193 RVA: 0x0000FC78 File Offset: 0x0000DE78
	[Token(Token = "0x17000514")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x1F59130", Offset = "0x1F59231", VA = "0x1F59130", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x060027D2 RID: 10194 RVA: 0x0000FC90 File Offset: 0x0000DE90
	[Token(Token = "0x17000515")]
	public int FocusPriority
	{
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x1F59140", Offset = "0x1F59241", VA = "0x1F59140", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x060027D3 RID: 10195 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
	[Token(Token = "0x17000516")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x1F59150", Offset = "0x1F59251", VA = "0x1F59150", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000517")]
	public ThrowController ThrowController
	{
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x1F59160", Offset = "0x1F59261", VA = "0x1F59160", Slot = "24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E40", Offset = "0x1A1F41")]
		get
		{
			return null;
		}
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x1F59170", Offset = "0x1F59271", VA = "0x1F59170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E50", Offset = "0x1A1F51")]
		private set
		{
		}
	}

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027D7 RID: 10199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000518")]
	public HoldItemController HoldItemController
	{
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x1F59180", Offset = "0x1F59281", VA = "0x1F59180")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E60", Offset = "0x1A1F61")]
		get
		{
			return null;
		}
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x1F59190", Offset = "0x1F59291", VA = "0x1F59190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E70", Offset = "0x1A1F71")]
		private set
		{
		}
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x1F591A0", Offset = "0x1F592A1", VA = "0x1F591A0")]
	public void UpdateModelPrefab([Optional] Action<OnGroundItem> action)
	{
	}

	// Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x1F59660", Offset = "0x1F59761", VA = "0x1F59660", Slot = "22")]
	public void OnHold()
	{
	}

	// Token: 0x060027DA RID: 10202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x1F59700", Offset = "0x1F59801", VA = "0x1F59700", Slot = "23")]
	public void OnPutOn()
	{
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x1F59950", Offset = "0x1F59A51", VA = "0x1F59950")]
	public bool DoHoldToDrop()
	{
		return default(bool);
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x1F59C80", Offset = "0x1F59D81", VA = "0x1F59C80")]
	public void DestroyByCerberus()
	{
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B1")]
	[Address(RVA = "0x1F59D20", Offset = "0x1F59E21", VA = "0x1F59D20")]
	public void SetHideModel(bool setValue)
	{
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x1F59D70", Offset = "0x1F59E71", VA = "0x1F59D70")]
	public void RemoveFromManager()
	{
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B3")]
	[Address(RVA = "0x1F59D80", Offset = "0x1F59E81", VA = "0x1F59D80")]
	private void Awake()
	{
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B4")]
	[Address(RVA = "0x1F59E80", Offset = "0x1F59F81", VA = "0x1F59E80")]
	private void OnDestroy()
	{
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x1F5A040", Offset = "0x1F5A141", VA = "0x1F5A040")]
	public static OnGroundItem CreateOnGroundItem(ItemData itemData, OnGroundItem.SpawnReason reason, [Optional] Action<OnGroundItem> action)
	{
		return null;
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B6")]
	[Address(RVA = "0x1F5A390", Offset = "0x1F5A491", VA = "0x1F5A390")]
	private void Start()
	{
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B7")]
	[Address(RVA = "0x1F5ADD0", Offset = "0x1F5AED1", VA = "0x1F5ADD0", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021B8")]
	[Address(RVA = "0x1F5ADC0", Offset = "0x1F5AEC1", VA = "0x1F5ADC0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x0000FCD8 File Offset: 0x0000DED8
	[Token(Token = "0x60021B9")]
	[Address(RVA = "0x1F5ADE0", Offset = "0x1F5AEE1", VA = "0x1F5ADE0", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x1F5B140", Offset = "0x1F5B241", VA = "0x1F5B140", Slot = "33")]
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID)
	{
		return ButtonInteractType.None;
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x1F5B650", Offset = "0x1F5B751", VA = "0x1F5B650")]
	private void Hold_Enter()
	{
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x1F5B6F0", Offset = "0x1F5B7F1", VA = "0x1F5B6F0")]
	private void Hold_Exit()
	{
	}

	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0000FD08 File Offset: 0x0000DF08
	// (set) Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000519")]
	public bool IsRemoveCandidate
	{
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x1F5B710", Offset = "0x1F5B811", VA = "0x1F5B710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E80", Offset = "0x1A1F81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x1F5B720", Offset = "0x1F5B821", VA = "0x1F5B720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1E90", Offset = "0x1A1F91")]
		private set
		{
		}
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x1F5B730", Offset = "0x1F5B831", VA = "0x1F5B730")]
	private void OnGround_Enter()
	{
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x1F5B7B0", Offset = "0x1F5B8B1", VA = "0x1F5B7B0")]
	private void OnGround_Update()
	{
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x1F5B8E0", Offset = "0x1F5B9E1", VA = "0x1F5B8E0")]
	private void OnGround_Exit()
	{
	}

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x060027EE RID: 10222 RVA: 0x0000FD20 File Offset: 0x0000DF20
	[Token(Token = "0x1700051A")]
	public float FadeAlpha
	{
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x1F5B960", Offset = "0x1F5BA61", VA = "0x1F5B960")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x1F597C0", Offset = "0x1F598C1", VA = "0x1F597C0", Slot = "34")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x1F5BA10", Offset = "0x1F5BB11", VA = "0x1F5BA10")]
	private void OnGroundJust_Enter()
	{
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x1F5BA70", Offset = "0x1F5BB71", VA = "0x1F5BA70")]
	private void OnGroundJust_Update()
	{
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x1F5BB60", Offset = "0x1F5BC61", VA = "0x1F5BB60")]
	private void Physics_Enter()
	{
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x1F5BBE0", Offset = "0x1F5BCE1", VA = "0x1F5BBE0")]
	private void Physics_FixedUpdate()
	{
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x1F5BD80", Offset = "0x1F5BE81", VA = "0x1F5BD80")]
	private void AnyPickup_Enter()
	{
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x1F5BFD0", Offset = "0x1F5C0D1", VA = "0x1F5BFD0")]
	private void AnyPickup_Update()
	{
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x1F5C8E0", Offset = "0x1F5C9E1", VA = "0x1F5C8E0")]
	private void AnyPickup_Exit()
	{
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x1F5C9C0", Offset = "0x1F5CAC1", VA = "0x1F5C9C0")]
	private void NotPickup_Enter()
	{
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x1F5CA60", Offset = "0x1F5CB61", VA = "0x1F5CA60")]
	private void NotPickup_Update()
	{
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x1F5CC10", Offset = "0x1F5CD11", VA = "0x1F5CC10")]
	private void NotPickup_Exit()
	{
	}

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x060027FA RID: 10234 RVA: 0x0000FD38 File Offset: 0x0000DF38
	// (set) Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700051B")]
	public Vector3 DropStartPoint
	{
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x1F5CC50", Offset = "0x1F5CD51", VA = "0x1F5CC50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x1F59C30", Offset = "0x1F59D31", VA = "0x1F59C30")]
		set
		{
		}
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x1F5CC60", Offset = "0x1F5CD61", VA = "0x1F5CC60")]
	private void Drop_Enter()
	{
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x1F5CD10", Offset = "0x1F5CE11", VA = "0x1F5CD10")]
	private void Drop_Update()
	{
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x1F5CF40", Offset = "0x1F5D041", VA = "0x1F5CF40")]
	private void Drop_Exit()
	{
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x1F5CFF0", Offset = "0x1F5D0F1", VA = "0x1F5CFF0")]
	private void Throw_Enter()
	{
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x1F5D090", Offset = "0x1F5D191", VA = "0x1F5D090", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002801 RID: 10241 RVA: 0x0000FD50 File Offset: 0x0000DF50
	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x1F5D270", Offset = "0x1F5D371", VA = "0x1F5D270", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x1F5D2A0", Offset = "0x1F5D3A1", VA = "0x1F5D2A0", Slot = "19")]
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x0000FD68 File Offset: 0x0000DF68
	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x1F5B020", Offset = "0x1F5B121", VA = "0x1F5B020", Slot = "20")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x0000FD80 File Offset: 0x0000DF80
	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x1F5D4E0", Offset = "0x1F5D5E1", VA = "0x1F5D4E0", Slot = "21")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x0000FD98 File Offset: 0x0000DF98
	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x1F5B5D0", Offset = "0x1F5B6D1", VA = "0x1F5B5D0", Slot = "30")]
	public bool CanPuton()
	{
		return default(bool);
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x1F5D4F0", Offset = "0x1F5D5F1", VA = "0x1F5D4F0", Slot = "31")]
	public bool CanRuckIn()
	{
		return default(bool);
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x1F5D570", Offset = "0x1F5D671", VA = "0x1F5D570", Slot = "39")]
	public void DoSmash(HumanController humanController)
	{
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x1F5D580", Offset = "0x1F5D681", VA = "0x1F5D580", Slot = "40")]
	public bool CanSmash(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x1F5D590", Offset = "0x1F5D691", VA = "0x1F5D590", Slot = "41")]
	public void DoBreak(HumanController humanController)
	{
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x1F5DB20", Offset = "0x1F5DC21", VA = "0x1F5DB20", Slot = "42")]
	public bool CanBreak(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x1F5DB50", Offset = "0x1F5DC51", VA = "0x1F5DB50", Slot = "43")]
	public void DoChop(HumanController humanController)
	{
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x1F5DE10", Offset = "0x1F5DF11", VA = "0x1F5DE10", Slot = "44")]
	public bool CanChop(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x1F5DE40", Offset = "0x1F5DF41", VA = "0x1F5DE40", Slot = "37")]
	public void DoSlash(HumanController humanController)
	{
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x0000FE10 File Offset: 0x0000E010
	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x1F5DFA0", Offset = "0x1F5E0A1", VA = "0x1F5DFA0", Slot = "38")]
	public bool CanSlash(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x1F5E0E0", Offset = "0x1F5E1E1", VA = "0x1F5E0E0", Slot = "35")]
	public void DoPlow(HumanController humanController)
	{
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x0000FE28 File Offset: 0x0000E028
	[Token(Token = "0x60021E4")]
	[Address(RVA = "0x1F5E270", Offset = "0x1F5E371", VA = "0x1F5E270", Slot = "36")]
	public bool CanPlow(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021E5")]
	[Address(RVA = "0x1F5D850", Offset = "0x1F5D951", VA = "0x1F5D850")]
	private void ChangeResourceItem(ItemID itemId, bool isSpread = true)
	{
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x0000FE40 File Offset: 0x0000E040
	[Token(Token = "0x60021E6")]
	[Address(RVA = "0x1F5E360", Offset = "0x1F5E461", VA = "0x1F5E360", Slot = "32")]
	public bool OnTakeDamage(DamageResult result)
	{
		return default(bool);
	}

	// Token: 0x06002813 RID: 10259 RVA: 0x0000FE58 File Offset: 0x0000E058
	[Token(Token = "0x60021E7")]
	[Address(RVA = "0x1F59AD0", Offset = "0x1F59BD1", VA = "0x1F59AD0")]
	private bool DetectFloorLayer(Vector3 origin, out RaycastHit hitResult)
	{
		return default(bool);
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x0000FE70 File Offset: 0x0000E070
	[Token(Token = "0x60021E8")]
	[Address(RVA = "0x1F5E380", Offset = "0x1F5E481", VA = "0x1F5E380", Slot = "25")]
	public bool CanThrow()
	{
		return default(bool);
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x1F5E390", Offset = "0x1F5E491", VA = "0x1F5E390", Slot = "26")]
	public void OnThrow()
	{
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x0000FE88 File Offset: 0x0000E088
	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x1F5E430", Offset = "0x1F5E531", VA = "0x1F5E430", Slot = "27")]
	public bool HitCheck(HitResult result, ThrowController throwController)
	{
		return default(bool);
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x1F5E6F0", Offset = "0x1F5E7F1", VA = "0x1F5E6F0", Slot = "28")]
	public void OnPutOnByThrow()
	{
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021EC")]
	[Address(RVA = "0x1F5E780", Offset = "0x1F5E881", VA = "0x1F5E780", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
	[Token(Token = "0x60021ED")]
	[Address(RVA = "0x1F5E790", Offset = "0x1F5E891", VA = "0x1F5E790", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x1F5E7A0", Offset = "0x1F5E8A1", VA = "0x1F5E7A0")]
	public OnGroundItem()
	{
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F0")]
	[Address(RVA = "0x1F5E8B0", Offset = "0x1F5E9B1", VA = "0x1F5E8B0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x1F5E8C0", Offset = "0x1F5E9C1", VA = "0x1F5E8C0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006F46 RID: 28486
	[Token(Token = "0x40067F8")]
	private const float kBackstepDistance = 0.05f;

	// Token: 0x04006F47 RID: 28487
	[Token(Token = "0x40067F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168480", Offset = "0x168581")]
	private ItemData <ItemData>k__BackingField;

	// Token: 0x04006F48 RID: 28488
	[Token(Token = "0x40067FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody Rigidbody;

	// Token: 0x04006F49 RID: 28489
	[Token(Token = "0x40067FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SphereCollider HitCollider;

	// Token: 0x04006F4A RID: 28490
	[Token(Token = "0x40067FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168490", Offset = "0x168591")]
	private FieldItemSpawnID <FieldItemSpawnID>k__BackingField;

	// Token: 0x04006F4B RID: 28491
	[Token(Token = "0x40067FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StateMachine<OnGroundItem.OnGroundItemState> sm;

	// Token: 0x04006F4C RID: 28492
	[Token(Token = "0x40067FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1684A0", Offset = "0x1685A1")]
	private Transform <Models>k__BackingField;

	// Token: 0x04006F4D RID: 28493
	[Token(Token = "0x40067FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1684B0", Offset = "0x1685B1")]
	private Renderer[] <ModelsMeshes>k__BackingField;

	// Token: 0x04006F4E RID: 28494
	[Token(Token = "0x4006800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private MeshFadeController FadeController;

	// Token: 0x04006F4F RID: 28495
	[Token(Token = "0x4006801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve DropSpeedXZ;

	// Token: 0x04006F50 RID: 28496
	[Token(Token = "0x4006802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve DropSpeedY1;

	// Token: 0x04006F51 RID: 28497
	[Token(Token = "0x4006803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AnimationCurve DropSpeedY2;

	// Token: 0x04006F52 RID: 28498
	[Token(Token = "0x4006804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AnimationCurve PickupScale;

	// Token: 0x04006F53 RID: 28499
	[Token(Token = "0x4006805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ParticleSystem KirakiraEffect;

	// Token: 0x04006F54 RID: 28500
	[Token(Token = "0x4006806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168520", Offset = "0x168621")]
	private bool <IsEntry>k__BackingField;

	// Token: 0x04006F55 RID: 28501
	[Token(Token = "0x4006807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168530", Offset = "0x168631")]
	private bool <IsHandCuffs>k__BackingField;

	// Token: 0x04006F56 RID: 28502
	[Token(Token = "0x4006808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float PhysicsTime;

	// Token: 0x04006F57 RID: 28503
	[Token(Token = "0x4006809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float CurrentPhysicsTime;

	// Token: 0x04006F58 RID: 28504
	[Token(Token = "0x400680A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168540", Offset = "0x168641")]
	private bool <IsHide>k__BackingField;

	// Token: 0x04006F59 RID: 28505
	[Token(Token = "0x400680B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168550", Offset = "0x168651")]
	private ThrowController <ThrowController>k__BackingField;

	// Token: 0x04006F5A RID: 28506
	[Token(Token = "0x400680C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168560", Offset = "0x168661")]
	private HoldItemController <HoldItemController>k__BackingField;

	// Token: 0x04006F5B RID: 28507
	[Token(Token = "0x400680D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool IsLoading;

	// Token: 0x04006F5C RID: 28508
	[Token(Token = "0x400680E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly OnGroundItem.OnGroundItemState[] ReasonToState;

	// Token: 0x04006F5D RID: 28509
	[Token(Token = "0x400680F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly bool[] ReasonToIsManage;

	// Token: 0x04006F5E RID: 28510
	[Token(Token = "0x4006810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private OnGroundItem.SpawnReason m_SpawnReason;

	// Token: 0x04006F5F RID: 28511
	[Token(Token = "0x4006811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OnGroundItem.OnGroundItemState InitialState;

	// Token: 0x04006F60 RID: 28512
	[Token(Token = "0x4006812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static GameObject BaseAssetOnGroundItem;

	// Token: 0x04006F61 RID: 28513
	[Token(Token = "0x4006813")]
	private const float RemoveTime = 4f;

	// Token: 0x04006F62 RID: 28514
	[Token(Token = "0x4006814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float RemoveElapsedTime;

	// Token: 0x04006F63 RID: 28515
	[Token(Token = "0x4006815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168570", Offset = "0x168671")]
	private bool <IsRemoveCandidate>k__BackingField;

	// Token: 0x04006F64 RID: 28516
	[Token(Token = "0x4006816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float JustTimer;

	// Token: 0x04006F65 RID: 28517
	[Token(Token = "0x4006817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly float OverJustTimer;

	// Token: 0x04006F66 RID: 28518
	[Token(Token = "0x4006818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 prevPosition;

	// Token: 0x04006F67 RID: 28519
	[Token(Token = "0x4006819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ActorController PickupOwner;

	// Token: 0x04006F68 RID: 28520
	[Token(Token = "0x400681A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 PickupStartPoint;

	// Token: 0x04006F69 RID: 28521
	[Token(Token = "0x400681B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private readonly float PickupTime;

	// Token: 0x04006F6A RID: 28522
	[Token(Token = "0x400681C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly float PickupBounceHeight;

	// Token: 0x04006F6B RID: 28523
	[Token(Token = "0x400681D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private readonly float BasePickupHeight;

	// Token: 0x04006F6C RID: 28524
	[Token(Token = "0x400681E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float CurrentPickupTime;

	// Token: 0x04006F6D RID: 28525
	[Token(Token = "0x400681F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool IsPickupRight;

	// Token: 0x04006F6E RID: 28526
	[Token(Token = "0x4006820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector3 _DropStartPoint;

	// Token: 0x04006F6F RID: 28527
	[Token(Token = "0x4006821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "HideInInspector", RVA = "0x168580", Offset = "0x168681")]
	public Vector3 DropEndPoint;

	// Token: 0x04006F70 RID: 28528
	[Token(Token = "0x4006822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float DropTime;

	// Token: 0x04006F71 RID: 28529
	[Token(Token = "0x4006823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float DropHeight;

	// Token: 0x04006F72 RID: 28530
	[Token(Token = "0x4006824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private AnimationCurve CurrentCurve;

	// Token: 0x04006F73 RID: 28531
	[Token(Token = "0x4006825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float CurrentDropTime;

	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200114D")]
	private enum OnGroundItemState
	{
		// Token: 0x04006F75 RID: 28533
		[Token(Token = "0x40193C2")]
		Physics,
		// Token: 0x04006F76 RID: 28534
		[Token(Token = "0x40193C3")]
		OnGroundJust,
		// Token: 0x04006F77 RID: 28535
		[Token(Token = "0x40193C4")]
		OnGround,
		// Token: 0x04006F78 RID: 28536
		[Token(Token = "0x40193C5")]
		Hold,
		// Token: 0x04006F79 RID: 28537
		[Token(Token = "0x40193C6")]
		Throw,
		// Token: 0x04006F7A RID: 28538
		[Token(Token = "0x40193C7")]
		AnyPickup,
		// Token: 0x04006F7B RID: 28539
		[Token(Token = "0x40193C8")]
		NotPickup,
		// Token: 0x04006F7C RID: 28540
		[Token(Token = "0x40193C9")]
		Drop
	}

	// Token: 0x0200064B RID: 1611
	[Token(Token = "0x200114E")]
	private enum Command
	{
		// Token: 0x04006F7E RID: 28542
		[Token(Token = "0x40193CB")]
		OnHold,
		// Token: 0x04006F7F RID: 28543
		[Token(Token = "0x40193CC")]
		OnThrow,
		// Token: 0x04006F80 RID: 28544
		[Token(Token = "0x40193CD")]
		OnPuton,
		// Token: 0x04006F81 RID: 28545
		[Token(Token = "0x40193CE")]
		OffPhysics,
		// Token: 0x04006F82 RID: 28546
		[Token(Token = "0x40193CF")]
		OnAnyPickup,
		// Token: 0x04006F83 RID: 28547
		[Token(Token = "0x40193D0")]
		PostPickup,
		// Token: 0x04006F84 RID: 28548
		[Token(Token = "0x40193D1")]
		NotPickup,
		// Token: 0x04006F85 RID: 28549
		[Token(Token = "0x40193D2")]
		EndJust,
		// Token: 0x04006F86 RID: 28550
		[Token(Token = "0x40193D3")]
		DropEnd,
		// Token: 0x04006F87 RID: 28551
		[Token(Token = "0x40193D4")]
		HoldToDrop,
		// Token: 0x04006F88 RID: 28552
		[Token(Token = "0x40193D5")]
		HoldToPhysics,
		// Token: 0x04006F89 RID: 28553
		[Token(Token = "0x40193D6")]
		OnHit,
		// Token: 0x04006F8A RID: 28554
		[Token(Token = "0x40193D7")]
		Remove
	}

	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200114F")]
	public enum SpawnReason
	{
		// Token: 0x04006F8C RID: 28556
		[Token(Token = "0x40193D9")]
		FromInventory,
		// Token: 0x04006F8D RID: 28557
		[Token(Token = "0x40193DA")]
		FromSpawner,
		// Token: 0x04006F8E RID: 28558
		[Token(Token = "0x40193DB")]
		FromFarm,
		// Token: 0x04006F8F RID: 28559
		[Token(Token = "0x40193DC")]
		FarmObstacle,
		// Token: 0x04006F90 RID: 28560
		[Token(Token = "0x40193DD")]
		FromHanded,
		// Token: 0x04006F91 RID: 28561
		[Token(Token = "0x40193DE")]
		FromEventSpawn,
		// Token: 0x04006F92 RID: 28562
		[Token(Token = "0x40193DF")]
		FromTresureBox,
		// Token: 0x04006F93 RID: 28563
		[Token(Token = "0x40193E0")]
		HandCuffsItem,
		// Token: 0x04006F94 RID: 28564
		[Token(Token = "0x40193E1")]
		FromManager,
		// Token: 0x04006F95 RID: 28565
		[Token(Token = "0x40193E2")]
		Max
	}

	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x2001150")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158190", Offset = "0x158291")]
	private sealed class <>c__DisplayClass69_0
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007117")]
		[Address(RVA = "0x20C3A50", Offset = "0x20C3B51", VA = "0x20C3A50")]
		public <>c__DisplayClass69_0()
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007118")]
		[Address(RVA = "0x20C3A60", Offset = "0x20C3B61", VA = "0x20C3A60")]
		internal void <UpdateModelPrefab>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04006F96 RID: 28566
		[Token(Token = "0x40193E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnGroundItem <>4__this;

		// Token: 0x04006F97 RID: 28567
		[Token(Token = "0x40193E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<OnGroundItem> action;
	}
}
