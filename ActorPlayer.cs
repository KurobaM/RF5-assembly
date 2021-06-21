using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x020000EC RID: 236
[Token(Token = "0x20000BD")]
public static class ActorPlayer
{
	// Token: 0x17000120 RID: 288
	// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011D")]
	public static Actor Actor
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1D51F20", Offset = "0x1D52021", VA = "0x1D51F20")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x060004FA RID: 1274 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x1700011E")]
	public static bool IsSpawn
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1D51FA0", Offset = "0x1D520A1", VA = "0x1D51FA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060004FB RID: 1275 RVA: 0x00003C90 File Offset: 0x00001E90
	// (set) Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011F")]
	public static Gender Gender
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1D52140", Offset = "0x1D52241", VA = "0x1D52140")]
		get
		{
			return Gender.None;
		}
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1D52170", Offset = "0x1D52271", VA = "0x1D52170")]
		set
		{
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060004FD RID: 1277 RVA: 0x00003CA8 File Offset: 0x00001EA8
	// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000120")]
	public static Gender ModelGender
	{
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1D521B0", Offset = "0x1D522B1", VA = "0x1D521B0")]
		get
		{
			return Gender.None;
		}
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1D521E0", Offset = "0x1D522E1", VA = "0x1D521E0")]
		set
		{
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060004FF RID: 1279 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x17000121")]
	public static bool IsMale
	{
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1D52220", Offset = "0x1D52321", VA = "0x1D52220")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000500 RID: 1280 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x17000122")]
	public static bool IsModelMale
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1D52250", Offset = "0x1D52351", VA = "0x1D52250")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x00003CF0 File Offset: 0x00001EF0
	// (set) Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000123")]
	public static VariationNo CostumeNo
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1D52280", Offset = "0x1D52381", VA = "0x1D52280")]
		get
		{
			return VariationNo.VARIA_000;
		}
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1D522B0", Offset = "0x1D523B1", VA = "0x1D522B0")]
		set
		{
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000124")]
	public static HumanStatus Status
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1D522F0", Offset = "0x1D523F1", VA = "0x1D522F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000504 RID: 1284 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x17000125")]
	public static bool IsDead
	{
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1D52430", Offset = "0x1D52531", VA = "0x1D52430")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x17000126")]
	public static bool IsMannequin
	{
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1D524A0", Offset = "0x1D525A1", VA = "0x1D524A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000506 RID: 1286 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x17000127")]
	public static bool IsPlayable
	{
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1D52590", Offset = "0x1D52691", VA = "0x1D52590")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x17000128")]
	public static bool IsShortPlay
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1D52680", Offset = "0x1D52781", VA = "0x1D52680")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000129")]
	public static Transform Player
	{
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1D52770", Offset = "0x1D52871", VA = "0x1D52770")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012A")]
	public static PlayerCharacterController PC
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1D52860", Offset = "0x1D52961", VA = "0x1D52860")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012B")]
	public static ActorController ActiveController
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1D529B0", Offset = "0x1D52AB1", VA = "0x1D529B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012C")]
	public static SpcController SpcController
	{
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1D52A90", Offset = "0x1D52B91", VA = "0x1D52A90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x0600050C RID: 1292 RVA: 0x00003D68 File Offset: 0x00001F68
	// (set) Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700012D")]
	public static bool LoadCacheOn
	{
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1D52BE0", Offset = "0x1D52CE1", VA = "0x1D52BE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A430", Offset = "0x19A531")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1D52C50", Offset = "0x1D52D51", VA = "0x1D52C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A440", Offset = "0x19A541")]
		set
		{
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x1D52CC0", Offset = "0x1D52DC1", VA = "0x1D52CC0")]
	public static void Spawn()
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x1D52F60", Offset = "0x1D53061", VA = "0x1D52F60")]
	public static void PlayerModelLoad()
	{
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1D53230", Offset = "0x1D53331", VA = "0x1D53230")]
	public static void CreateFirst(bool isMale, ActorType actorType = ActorType.PlayerBase)
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1D53700", Offset = "0x1D53801", VA = "0x1D53700")]
	public static void ChangeGender()
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x1D53A20", Offset = "0x1D53B21", VA = "0x1D53A20")]
	public static void ChangeCostume(VariationNo variationNo)
	{
	}

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BA90", Offset = "0x15BB91")]
	private static bool <LoadCacheOn>k__BackingField;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x4")]
	private static Loader.ID.Character CacheMaleModel;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x8")]
	private static Loader.ID.Character CacheFemaleModel;
}
