using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000875 RID: 2165
[Token(Token = "0x2000599")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146830", Offset = "0x146931")]
[Serializable]
public class PatrolPointDataTable : ScriptableObject
{
	// Token: 0x0600393C RID: 14652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x213C500", Offset = "0x213C601", VA = "0x213C500")]
	public PatrolPointDataTable()
	{
	}

	// Token: 0x04007C8A RID: 31882
	[Token(Token = "0x400709D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public RouteTo[] RoutePatrolPointsFrom;

	// Token: 0x04007C8B RID: 31883
	[Token(Token = "0x400709E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string[] PlacePatrolPoints;
}
