using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000B9")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x144C70", Offset = "0x144D71")]
public class Actor
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000450 RID: 1104 RVA: 0x00003960 File Offset: 0x00001B60
	// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F9")]
	public ActorID ActorID
	{
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1D46540", Offset = "0x1D46641", VA = "0x1D46540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1B0", Offset = "0x19A2B1")]
		get
		{
			return ActorID.act000;
		}
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1D46550", Offset = "0x1D46651", VA = "0x1D46550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1C0", Offset = "0x19A2C1")]
		private set
		{
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003978 File Offset: 0x00001B78
	// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FA")]
	public ActorType ActorType
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1D46560", Offset = "0x1D46661", VA = "0x1D46560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1D0", Offset = "0x19A2D1")]
		get
		{
			return ActorType.NullBase;
		}
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1D46570", Offset = "0x1D46671", VA = "0x1D46570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1E0", Offset = "0x19A2E1")]
		private set
		{
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000454 RID: 1108 RVA: 0x00003990 File Offset: 0x00001B90
	// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FB")]
	public ActorGroup ActorGroup
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1D46580", Offset = "0x1D46681", VA = "0x1D46580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1F0", Offset = "0x19A2F1")]
		get
		{
			return ActorGroup.Human;
		}
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1D46590", Offset = "0x1D46691", VA = "0x1D46590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A200", Offset = "0x19A301")]
		private set
		{
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000456 RID: 1110 RVA: 0x000039A8 File Offset: 0x00001BA8
	// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FC")]
	public CharID CharID
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1D465A0", Offset = "0x1D466A1", VA = "0x1D465A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A210", Offset = "0x19A311")]
		get
		{
			return CharID.ch000;
		}
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1D465B0", Offset = "0x1D466B1", VA = "0x1D465B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A220", Offset = "0x19A321")]
		private set
		{
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000458 RID: 1112 RVA: 0x000039C0 File Offset: 0x00001BC0
	// (set) Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FD")]
	public HairType HairType
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1D465C0", Offset = "0x1D466C1", VA = "0x1D465C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A230", Offset = "0x19A331")]
		get
		{
			return HairType.HAIR00_00;
		}
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1D465D0", Offset = "0x1D466D1", VA = "0x1D465D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A240", Offset = "0x19A341")]
		private set
		{
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600045A RID: 1114 RVA: 0x000039D8 File Offset: 0x00001BD8
	// (set) Token: 0x0600045B RID: 1115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FE")]
	public VariationNo VariationNo
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1D465E0", Offset = "0x1D466E1", VA = "0x1D465E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A250", Offset = "0x19A351")]
		get
		{
			return VariationNo.VARIA_000;
		}
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1D465F0", Offset = "0x1D466F1", VA = "0x1D465F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A260", Offset = "0x19A361")]
		private set
		{
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600045C RID: 1116 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x170000FF")]
	public bool IsActive
	{
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1D46600", Offset = "0x1D46701", VA = "0x1D46600")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x00003A08 File Offset: 0x00001C08
	// (set) Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000100")]
	public bool DispOn
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1D46610", Offset = "0x1D46711", VA = "0x1D46610")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1D46620", Offset = "0x1D46721", VA = "0x1D46620")]
		set
		{
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003A20 File Offset: 0x00001C20
	// (set) Token: 0x06000460 RID: 1120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000101")]
	public bool IsAnimatorRebind
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1D466E0", Offset = "0x1D467E1", VA = "0x1D466E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A270", Offset = "0x19A371")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1D466F0", Offset = "0x1D467F1", VA = "0x1D466F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A280", Offset = "0x19A381")]
		set
		{
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000102")]
	public Transform Transform
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1D46700", Offset = "0x1D46801", VA = "0x1D46700")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000463 RID: 1123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000103")]
	public Transform[] BaseTransform
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1D46720", Offset = "0x1D46821", VA = "0x1D46720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A290", Offset = "0x19A391")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1D46730", Offset = "0x1D46831", VA = "0x1D46730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2A0", Offset = "0x19A3A1")]
		private set
		{
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000465 RID: 1125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000104")]
	public ActorController[] BaseController
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1D46740", Offset = "0x1D46841", VA = "0x1D46740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2B0", Offset = "0x19A3B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1D46750", Offset = "0x1D46851", VA = "0x1D46750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2C0", Offset = "0x19A3C1")]
		private set
		{
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000105")]
	public Transform Item
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1D46760", Offset = "0x1D46861", VA = "0x1D46760")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000106")]
	public Transform CharacterTransform
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1D467A0", Offset = "0x1D468A1", VA = "0x1D467A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2D0", Offset = "0x19A3D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1D467B0", Offset = "0x1D468B1", VA = "0x1D467B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2E0", Offset = "0x19A3E1")]
		private set
		{
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000107")]
	public CharacterStatusBase StatusController
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1D467C0", Offset = "0x1D468C1", VA = "0x1D467C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A2F0", Offset = "0x19A3F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1D467D0", Offset = "0x1D468D1", VA = "0x1D467D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A300", Offset = "0x19A401")]
		set
		{
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600046C RID: 1132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000108")]
	public ActorController ActiveController
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1D467E0", Offset = "0x1D468E1", VA = "0x1D467E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A310", Offset = "0x19A411")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1D467F0", Offset = "0x1D468F1", VA = "0x1D467F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A320", Offset = "0x19A421")]
		private set
		{
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x0600046D RID: 1133 RVA: 0x00003A38 File Offset: 0x00001C38
	// (set) Token: 0x0600046E RID: 1134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000109")]
	public ActorType PreviousActorType
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1D46800", Offset = "0x1D46901", VA = "0x1D46800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A330", Offset = "0x19A431")]
		get
		{
			return ActorType.NullBase;
		}
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1D46810", Offset = "0x1D46911", VA = "0x1D46810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A340", Offset = "0x19A441")]
		private set
		{
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x0600046F RID: 1135 RVA: 0x00003A50 File Offset: 0x00001C50
	// (set) Token: 0x06000470 RID: 1136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700010A")]
	public bool IsCopyTransform
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1D46820", Offset = "0x1D46921", VA = "0x1D46820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A350", Offset = "0x19A451")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1D46830", Offset = "0x1D46931", VA = "0x1D46830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A360", Offset = "0x19A461")]
		set
		{
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x1700010B")]
	public bool IsPlayable
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1D46840", Offset = "0x1D46941", VA = "0x1D46840")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000472 RID: 1138 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x1700010C")]
	public bool IsPartner
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1D46850", Offset = "0x1D46951", VA = "0x1D46850")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000473 RID: 1139 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x1700010D")]
	public bool IsShortPlay
	{
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1D46860", Offset = "0x1D46961", VA = "0x1D46860")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x1700010E")]
	public bool IsNpc
	{
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1D46870", Offset = "0x1D46971", VA = "0x1D46870")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1D46880", Offset = "0x1D46981", VA = "0x1D46880")]
	public ActorController GetController(ActorType type)
	{
		return null;
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1D468C0", Offset = "0x1D469C1", VA = "0x1D468C0")]
	public void InitCharacterTransform()
	{
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1D469C0", Offset = "0x1D46AC1", VA = "0x1D469C0")]
	public void Create(ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type)
	{
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1D46D80", Offset = "0x1D46E81", VA = "0x1D46D80")]
	private Actor.State CreateChoice(ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type)
	{
		return Actor.State.NONE;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x1D47210", Offset = "0x1D47311", VA = "0x1D47210")]
	public void Create(ActorType actor_type, CharID char_id)
	{
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x1D47220", Offset = "0x1D47321", VA = "0x1D47220")]
	public void Create()
	{
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1D47230", Offset = "0x1D47331", VA = "0x1D47230")]
	public void CreateRandom(ActorType actor_type = ActorType.NpcBase)
	{
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1D47030", Offset = "0x1D47131", VA = "0x1D47030")]
	public void SwitchBase(ActorType actor_type, bool is_copy = true)
	{
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x1D47800", Offset = "0x1D47901", VA = "0x1D47800")]
	public void SetMonster(ActorType actor_type, int base_loader_id, Transform transform, bool is_copy = true)
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x1D47990", Offset = "0x1D47A91", VA = "0x1D47990")]
	public void SetMonster(ActorType actor_type, Transform baseTransform, bool is_copy = true)
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x1D47FC0", Offset = "0x1D480C1", VA = "0x1D47FC0")]
	public void SetMonster(ActorType actor_type, Transform baseTransform, Transform transform, bool is_copy = true)
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1D48220", Offset = "0x1D48321", VA = "0x1D48220")]
	public MonsterControllerBase ReleaseMonster()
	{
		return null;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x1D48570", Offset = "0x1D48671", VA = "0x1D48570")]
	public void Delete()
	{
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x1D486D0", Offset = "0x1D487D1", VA = "0x1D486D0")]
	public void DeleteModel()
	{
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1D48960", Offset = "0x1D48A61", VA = "0x1D48960")]
	public Actor(ActorID id, ActorGroup group, Transform parent)
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1D48B30", Offset = "0x1D48C31", VA = "0x1D48B30")]
	public void Destroy()
	{
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1D482D0", Offset = "0x1D483D1", VA = "0x1D482D0")]
	private void Init()
	{
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1D48BE0", Offset = "0x1D48CE1", VA = "0x1D48BE0")]
	public void Update()
	{
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1D49050", Offset = "0x1D49151", VA = "0x1D49050")]
	private static void UpdateDummy(Actor actor)
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1D49060", Offset = "0x1D49161", VA = "0x1D49060")]
	private static void UpdateCreateBase(Actor actor)
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1D49280", Offset = "0x1D49381", VA = "0x1D49280")]
	private static void UpdateCreateChar(Actor actor)
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1D494D0", Offset = "0x1D495D1", VA = "0x1D494D0")]
	private static void UpdateCreateBaseOnly(Actor actor)
	{
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1D47D90", Offset = "0x1D47E91", VA = "0x1D47D90")]
	private static void UpdateComplete(Actor actor)
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1D48770", Offset = "0x1D48871", VA = "0x1D48770")]
	private void DestroyObject(Transform transform)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1D474E0", Offset = "0x1D475E1", VA = "0x1D474E0")]
	private void ResetBase()
	{
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1D485A0", Offset = "0x1D486A1", VA = "0x1D485A0")]
	private void DestroyBase()
	{
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1D496E0", Offset = "0x1D497E1", VA = "0x1D496E0")]
	private void DestroyBase(ActorType actor_type)
	{
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1D47BE0", Offset = "0x1D47CE1", VA = "0x1D47BE0")]
	private void SetNewBase(ActorType actor_type, Transform new_base)
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1D46F10", Offset = "0x1D47011", VA = "0x1D46F10")]
	private void BeforeSwitchBase(ActorType actorType)
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1D47330", Offset = "0x1D47431", VA = "0x1D47330")]
	private void CopyBaseTransform(Transform setTransform, [Optional] Transform copyTransform)
	{
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1D49890", Offset = "0x1D49991", VA = "0x1D49890")]
	public string GetActorInfomation()
	{
		return null;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1D49C10", Offset = "0x1D49D11", VA = "0x1D49C10")]
	public string GetBaseInfomation()
	{
		return null;
	}

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject gameObject;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8A0", Offset = "0x15B9A1")]
	private ActorID <ActorID>k__BackingField;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8B0", Offset = "0x15B9B1")]
	private ActorType <ActorType>k__BackingField;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8C0", Offset = "0x15B9C1")]
	private ActorGroup <ActorGroup>k__BackingField;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8D0", Offset = "0x15B9D1")]
	private CharID <CharID>k__BackingField;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8E0", Offset = "0x15B9E1")]
	private HairType <HairType>k__BackingField;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B8F0", Offset = "0x15B9F1")]
	private VariationNo <VariationNo>k__BackingField;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B900", Offset = "0x15BA01")]
	private bool <IsAnimatorRebind>k__BackingField;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B910", Offset = "0x15BA11")]
	private Transform[] <BaseTransform>k__BackingField;

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B920", Offset = "0x15BA21")]
	private ActorController[] <BaseController>k__BackingField;

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B930", Offset = "0x15BA31")]
	private Transform <CharacterTransform>k__BackingField;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B940", Offset = "0x15BA41")]
	private CharacterStatusBase <StatusController>k__BackingField;

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B950", Offset = "0x15BA51")]
	private ActorController <ActiveController>k__BackingField;

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B960", Offset = "0x15BA61")]
	private ActorType <PreviousActorType>k__BackingField;

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B970", Offset = "0x15BA71")]
	private bool <IsCopyTransform>k__BackingField;

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform copyBaseTransform;

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Transform> deleteTransforms;

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Actor.State updateState;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool dispOn;

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	private bool isBaseDestroy;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int loaderIdBase;

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int loaderIdChar;

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Actor.UpdateVJ[] updateVJ;

	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x2000FB5")]
	private enum State
	{
		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4018D00")]
		NONE,
		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4018D01")]
		CREATE_BASE,
		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4018D02")]
		CREATE_CHAR,
		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4018D03")]
		CREATE_BASEONLY,
		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4018D04")]
		COMPLETE,
		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4018D05")]
		Length
	}

	// Token: 0x020000E6 RID: 230
	// (Invoke) Token: 0x06000497 RID: 1175
	[Token(Token = "0x2000FB6")]
	private delegate void UpdateVJ(Actor actor);
}
