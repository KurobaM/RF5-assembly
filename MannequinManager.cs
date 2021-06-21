using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F3 RID: 243
[Token(Token = "0x20000C0")]
public class MannequinManager : MonoBehaviour
{
	// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1F17920", Offset = "0x1F17A21", VA = "0x1F17920")]
	public static void Add(ActorID actor_id)
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x1F17CE0", Offset = "0x1F17DE1", VA = "0x1F17CE0")]
	public static Actor GetMannequin()
	{
		return null;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x1F17E20", Offset = "0x1F17F21", VA = "0x1F17E20")]
	public static Actor GetActor(ActorID actorId)
	{
		return null;
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1F17F60", Offset = "0x1F18061", VA = "0x1F17F60")]
	public static void Clear()
	{
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000132")]
	private static MannequinManager Instance
	{
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1F17FC0", Offset = "0x1F180C1", VA = "0x1F17FC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A470", Offset = "0x19A571")]
		get
		{
			return null;
		}
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1F18010", Offset = "0x1F18111", VA = "0x1F18010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A480", Offset = "0x19A581")]
		set
		{
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1F18070", Offset = "0x1F18171", VA = "0x1F18070")]
	private void Awake()
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1F18150", Offset = "0x1F18251", VA = "0x1F18150")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1F17990", Offset = "0x1F17A91", VA = "0x1F17990")]
	private void CreateMannequin(ActorID actor_id)
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1F18360", Offset = "0x1F18461", VA = "0x1F18360")]
	private void Update()
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1F185C0", Offset = "0x1F186C1", VA = "0x1F185C0")]
	public MannequinManager()
	{
	}

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15BAB0", Offset = "0x15BBB1")]
	private int MANNEQIN_CACHE_MAX;

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x1C")]
	private int ManneqinEnableMax;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x20")]
	private List<Actor> Manneqins;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x28")]
	private List<Actor> DeleteManneqins;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BB00", Offset = "0x15BC01")]
	private static MannequinManager <Instance>k__BackingField;

	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x2000FBD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570C0", Offset = "0x1571C1")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x1F17F50", Offset = "0x1F18051", VA = "0x1F17F50")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0x1F18600", Offset = "0x1F18701", VA = "0x1F18600")]
		internal bool <GetActor>b__0(Actor actor)
		{
			return default(bool);
		}

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x4018D15")]
		[FieldOffset(Offset = "0x10")]
		public ActorID actorId;
	}

	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x2000FBE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570D0", Offset = "0x1571D1")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0x1F18350", Offset = "0x1F18451", VA = "0x1F18350")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x1F185D0", Offset = "0x1F186D1", VA = "0x1F185D0")]
		internal bool <CreateMannequin>b__0(Actor a)
		{
			return default(bool);
		}

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x4018D16")]
		[FieldOffset(Offset = "0x10")]
		public ActorID actor_id;
	}
}
