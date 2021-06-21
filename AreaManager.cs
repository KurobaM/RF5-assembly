using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000868 RID: 2152
[Token(Token = "0x200058C")]
[Serializable]
public class AreaManager : SingletonMonoBehaviour<AreaManager>
{
	// Token: 0x06003909 RID: 14601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x243ED60", Offset = "0x243EE61", VA = "0x243ED60", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x243EDB0", Offset = "0x243EEB1", VA = "0x243EDB0")]
	public void SetAreas(GameObject areas)
	{
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x243EF40", Offset = "0x243F041", VA = "0x243EF40")]
	public Area GetArea(Place place)
	{
		return null;
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x00013C50 File Offset: 0x00011E50
	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x243F200", Offset = "0x243F301", VA = "0x243F200")]
	public int GetCapacity(Place place)
	{
		return 0;
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x00013C68 File Offset: 0x00011E68
	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x243F240", Offset = "0x243F341", VA = "0x243F240")]
	public bool IsAvailable(Place place)
	{
		return default(bool);
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x243F270", Offset = "0x243F371", VA = "0x243F270")]
	public NpcPatrolPoint GetJobPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x0600390F RID: 14607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x243F350", Offset = "0x243F451", VA = "0x243F350")]
	public NpcPatrolPoint GetWaitJobPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x06003910 RID: 14608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x243F3A0", Offset = "0x243F4A1", VA = "0x243F3A0")]
	public NpcPatrolPoint GetSeatPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x06003911 RID: 14609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x243F3F0", Offset = "0x243F4F1", VA = "0x243F3F0")]
	public NpcPatrolPoint GetEatPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x243F440", Offset = "0x243F541", VA = "0x243F440")]
	public NpcPatrolPoint GetWaitSeatPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x06003913 RID: 14611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x243F490", Offset = "0x243F591", VA = "0x243F490")]
	public NpcPatrolPoint GetBedPatrolPoint(int NpcId, Place place)
	{
		return null;
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x243F4E0", Offset = "0x243F5E1", VA = "0x243F4E0")]
	public NpcPatrolPoint GetBathPatrolPoint(Gender gender)
	{
		return null;
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x243F510", Offset = "0x243F611", VA = "0x243F510")]
	public NpcPatrolPoint GetRelayPatrolPoint(NpcData npcData)
	{
		return null;
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x243F540", Offset = "0x243F641", VA = "0x243F540")]
	public NpcPatrolPoint GetDoorPoint(Place place)
	{
		return null;
	}

	// Token: 0x06003917 RID: 14615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x243F580", Offset = "0x243F681", VA = "0x243F580")]
	public NpcPatrolPoint ReadRotatePatrolPointEnd(Place place, int RotatePatternNumber)
	{
		return null;
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x243F5D0", Offset = "0x243F6D1", VA = "0x243F5D0")]
	public NpcPatrolPoint GetRotatePatrolPointEnd(Place place, int RotatePatternNumber, int NpcId)
	{
		return null;
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x243F620", Offset = "0x243F721", VA = "0x243F620")]
	public void FreeAllAreaPoints()
	{
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x00013C80 File Offset: 0x00011E80
	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x243F680", Offset = "0x243F781", VA = "0x243F680")]
	public Place GetPlace(FieldPlaceId FieldPlaceId)
	{
		return Place.Field;
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x00013C98 File Offset: 0x00011E98
	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x243F760", Offset = "0x243F861", VA = "0x243F760")]
	public FieldPlaceId ConvertSceneNameToFieldPlaceId(string sceneName)
	{
		return FieldPlaceId.None;
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x00013CB0 File Offset: 0x00011EB0
	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x243F840", Offset = "0x243F941", VA = "0x243F840")]
	public FieldPlaceId GetAreaPlaceId(Place place)
	{
		return FieldPlaceId.None;
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x243F920", Offset = "0x243FA21", VA = "0x243F920")]
	public string[] GetRoutePatrolPoint(int fromIndex, int toIndex)
	{
		return null;
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x00013CC8 File Offset: 0x00011EC8
	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x243FB80", Offset = "0x243FC81", VA = "0x243FB80")]
	public bool IsInDoor(Place place)
	{
		return default(bool);
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x00013CE0 File Offset: 0x00011EE0
	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x243F1B0", Offset = "0x243F2B1", VA = "0x243F1B0")]
	public Place ConvertPlaceId(Place _place)
	{
		return Place.Field;
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x00013CF8 File Offset: 0x00011EF8
	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x243FBA0", Offset = "0x243FCA1", VA = "0x243FBA0")]
	public Place ConvertIdPlace(int place)
	{
		return Place.Field;
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x243FBE0", Offset = "0x243FCE1", VA = "0x243FBE0")]
	public AreaManager()
	{
	}

	// Token: 0x04007C52 RID: 31826
	[Token(Token = "0x4007065")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<string, FieldPlaceId> SceneNameToFieldPlaceId;

	// Token: 0x04007C53 RID: 31827
	[Token(Token = "0x4007066")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Dictionary<Place, FieldPlaceId> PlaceToFieldPlaceId;

	// Token: 0x04007C54 RID: 31828
	[Token(Token = "0x4007067")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Dictionary<FieldPlaceId, Place> FieldPlaceIdToPlace;

	// Token: 0x04007C55 RID: 31829
	[Token(Token = "0x4007068")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public PatrolPointDataTable patrolPointDataTable;

	// Token: 0x04007C56 RID: 31830
	[Token(Token = "0x4007069")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Area[] Areas;

	// Token: 0x04007C57 RID: 31831
	[Token(Token = "0x400706A")]
	[FieldOffset(Offset = "0x28")]
	public bool Standby;

	// Token: 0x04007C58 RID: 31832
	[Token(Token = "0x400706B")]
	private const string PatrolPointDataTableExportPath = "Assets/Scripts/ShopArea/Table/";
}
