using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B5 RID: 437
[Token(Token = "0x2000158")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x145850", Offset = "0x145951")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145850", Offset = "0x145951")]
[Serializable]
public class TrackingCameraSettingTable : ScriptableObject
{
	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A2")]
	public TrackingCameraSetting Item
	{
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2075120", Offset = "0x2075221", VA = "0x2075120")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x20751E0", Offset = "0x20752E1", VA = "0x20751E0")]
	public Dictionary<TrackinCameraType, TrackingCameraSetting> GetTable()
	{
		return null;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x2075240", Offset = "0x2075341", VA = "0x2075240")]
	public TrackingCameraSettingTable()
	{
	}

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TrackingCameraSettingDictionary m_Table;
}
