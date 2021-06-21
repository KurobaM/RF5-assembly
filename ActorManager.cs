using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000BC")]
public class ActorManager : MonoBehaviour
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000116")]
	public static ActorDataTable ActorDataTable
	{
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1D4E960", Offset = "0x1D4EA61", VA = "0x1D4E960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A370", Offset = "0x19A471")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1D4E9B0", Offset = "0x1D4EAB1", VA = "0x1D4E9B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A380", Offset = "0x19A481")]
		private set
		{
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000117")]
	public static HumanDataTable HumanDataTable
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1D4EA10", Offset = "0x1D4EB11", VA = "0x1D4EA10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A390", Offset = "0x19A491")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1D4EA60", Offset = "0x1D4EB61", VA = "0x1D4EA60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3A0", Offset = "0x19A4A1")]
		private set
		{
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000118")]
	private static PartyData[] PartyDatas
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1D4EAC0", Offset = "0x1D4EBC1", VA = "0x1D4EAC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1D4EAF0", Offset = "0x1D4EBF1", VA = "0x1D4EAF0")]
	public static void InitializeForNewGame()
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1D4ECA0", Offset = "0x1D4EDA1", VA = "0x1D4ECA0")]
	public static void Initialize()
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1D4F000", Offset = "0x1D4F101", VA = "0x1D4F000")]
	public static void InitializeAfterSceneLoad()
	{
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000119")]
	public static PartyBase[] Parties
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1D4F4C0", Offset = "0x1D4F5C1", VA = "0x1D4F4C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3B0", Offset = "0x19A4B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1D4F510", Offset = "0x1D4F611", VA = "0x1D4F510")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3C0", Offset = "0x19A4C1")]
		private set
		{
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1D4F570", Offset = "0x1D4F671", VA = "0x1D4F570")]
	public static ActorID PartyMonsterActorId(int no)
	{
		return ActorID.act000;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1D4EB00", Offset = "0x1D4EC01", VA = "0x1D4EB00")]
	private static void PartyCreate()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x1D4F580", Offset = "0x1D4F681", VA = "0x1D4F580")]
	public static void PartyClear()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1D4F010", Offset = "0x1D4F111", VA = "0x1D4F010")]
	public static void PartyReset()
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1D4F7B0", Offset = "0x1D4F8B1", VA = "0x1D4F7B0")]
	public static int PartyFreeNo()
	{
		return 0;
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x1D4F860", Offset = "0x1D4F961", VA = "0x1D4F860")]
	public static bool PartyIsJoinedHandCuffs()
	{
		return default(bool);
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x1D4F970", Offset = "0x1D4FA71", VA = "0x1D4F970")]
	public static void PartyInHuman(int no, ActorID actorID)
	{
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1D4FE70", Offset = "0x1D4FF71", VA = "0x1D4FE70")]
	public static void PartyInMonster(int no, string name, EnemyStatusData mosterStatusData, bool inParty = true)
	{
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1D4FEC0", Offset = "0x1D4FFC1", VA = "0x1D4FEC0")]
	public static void PartyInMonster(int no, uint fmId)
	{
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x1D50120", Offset = "0x1D50221", VA = "0x1D50120")]
	public static void PartyInHandCuffs(int no, MonsterControllerBase enemy)
	{
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1D4FBC0", Offset = "0x1D4FCC1", VA = "0x1D4FBC0")]
	public static void PartyOut(int no)
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1D50470", Offset = "0x1D50571", VA = "0x1D50470")]
	public static void PartyAllOut()
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1D50510", Offset = "0x1D50611", VA = "0x1D50510")]
	public static bool PartyInMonsterCheck(uint fmId)
	{
		return default(bool);
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1D50650", Offset = "0x1D50751", VA = "0x1D50650")]
	public static List<uint> PartyInMonsterGetId()
	{
		return null;
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x00003C18 File Offset: 0x00001E18
	// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011A")]
	public static bool IsBusy
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1D508C0", Offset = "0x1D509C1", VA = "0x1D508C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3D0", Offset = "0x19A4D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1D50910", Offset = "0x1D50A11", VA = "0x1D50910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3E0", Offset = "0x19A4E1")]
		private set
		{
		}
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1D50970", Offset = "0x1D50A71", VA = "0x1D50970")]
	public static bool CheckVariationNo(ActorID actorId, VariationNo variationNo)
	{
		return default(bool);
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1D4A3F0", Offset = "0x1D4A4F1", VA = "0x1D4A3F0")]
	public static Actor GetActor(ActorID actorId)
	{
		return null;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1D50AF0", Offset = "0x1D50BF1", VA = "0x1D50AF0")]
	public static Actor Create(ActorID actor_id, ActorType type, CharID char_id, VariationNo variation_no = VariationNo.VARIA_000, HairType hair_type = HairType.HAIR00_00)
	{
		return null;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x1D50BC0", Offset = "0x1D50CC1", VA = "0x1D50BC0")]
	public static Actor Create(ActorID actor_id, ActorType type, CharID char_id)
	{
		return null;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x1D50C80", Offset = "0x1D50D81", VA = "0x1D50C80")]
	public static Actor SwitchBase(ActorID actor_id, ActorType actor_type, bool is_copy = true)
	{
		return null;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x1D50D30", Offset = "0x1D50E31", VA = "0x1D50D30")]
	public static void DestroyModel(ActorID actor_id)
	{
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000419")]
	[Address(RVA = "0x1D50E40", Offset = "0x1D50F41", VA = "0x1D50E40")]
	public static void Destroy(ActorID actor_id)
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1D50EE0", Offset = "0x1D50FE1", VA = "0x1D50EE0")]
	public static void DestroyAll()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x1D4ECC0", Offset = "0x1D4EDC1", VA = "0x1D4ECC0")]
	public static void InitializeStatusController()
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x1D51060", Offset = "0x1D51161", VA = "0x1D51060")]
	public static CharacterStatusBase GetStatus(ActorID actor_id)
	{
		return null;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x1D510F0", Offset = "0x1D511F1", VA = "0x1D510F0")]
	public static HumanStatus GetHumanStatus(ActorID actor_id)
	{
		return null;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1D51200", Offset = "0x1D51301", VA = "0x1D51200")]
	public static HumanStatusData GetHumanStatusData(ActorID actor_id)
	{
		return null;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x1D512F0", Offset = "0x1D513F1", VA = "0x1D512F0")]
	public static ItemData GetEquipItem(ActorID actor_id, EquipSlotType equip_slot_type)
	{
		return null;
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x1D51330", Offset = "0x1D51431", VA = "0x1D51330")]
	public static ItemData Equip(ActorID actor_id, EquipSlotType equip_slot_type, ItemData itemData)
	{
		return null;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x1D513A0", Offset = "0x1D514A1", VA = "0x1D513A0")]
	public static ItemData UnEquip(ActorID actor_id, EquipSlotType equip_slot_type)
	{
		return null;
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003C48 File Offset: 0x00001E48
	// (set) Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011B")]
	public bool EnableStatusUpdate
	{
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1D51410", Offset = "0x1D51511", VA = "0x1D51410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A3F0", Offset = "0x19A4F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1D51420", Offset = "0x1D51521", VA = "0x1D51420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A400", Offset = "0x19A501")]
		set
		{
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011C")]
	public static ActorManager Instance
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1D51430", Offset = "0x1D51531", VA = "0x1D51430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A410", Offset = "0x19A511")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1D51480", Offset = "0x1D51581", VA = "0x1D51480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A420", Offset = "0x19A521")]
		private set
		{
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x1D514E0", Offset = "0x1D515E1", VA = "0x1D514E0")]
	private void Awake()
	{
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x1D51900", Offset = "0x1D51A01", VA = "0x1D51900")]
	private void Start()
	{
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1D51930", Offset = "0x1D51A31", VA = "0x1D51930")]
	private void OnDestroy()
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1D51BA0", Offset = "0x1D51CA1", VA = "0x1D51BA0")]
	private void Update()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1D51DE0", Offset = "0x1D51EE1", VA = "0x1D51DE0")]
	public ActorManager()
	{
	}

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA30", Offset = "0x15BB31")]
	private static ActorDataTable <ActorDataTable>k__BackingField;

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA40", Offset = "0x15BB41")]
	private static HumanDataTable <HumanDataTable>k__BackingField;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x18")]
	private Actor[] Actors;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x20")]
	private CharacterStatusBase[] ActorStatusControllers;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA50", Offset = "0x15BB51")]
	private static PartyBase[] <Parties>k__BackingField;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA60", Offset = "0x15BB61")]
	private static bool <IsBusy>k__BackingField;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA70", Offset = "0x15BB71")]
	private bool <EnableStatusUpdate>k__BackingField;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA80", Offset = "0x15BB81")]
	private static ActorManager <Instance>k__BackingField;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x29")]
	private bool IsActive;

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x2000FB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157090", Offset = "0x157191")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB7")]
		[Address(RVA = "0x1D51EF0", Offset = "0x1D51FF1", VA = "0x1D51EF0")]
		public <>c()
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0x1D51F00", Offset = "0x1D52001", VA = "0x1D51F00")]
		internal bool <PartyOut>b__29_0(PartyData p)
		{
			return default(bool);
		}

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x4018D0B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActorManager.<>c <>9;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x4018D0C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PartyData, bool> <>9__29_0;
	}
}
