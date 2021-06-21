using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000382 RID: 898
[Token(Token = "0x20002AC")]
public class HumanViewDataTable : ScriptableObject
{
	// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600145C")]
	[Address(RVA = "0x222B9E0", Offset = "0x222BAE1", VA = "0x222B9E0")]
	public HumanViewDataTable()
	{
	}

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GameObject[] HumanPrefabs;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public AnimationClip[] BodyAnimations;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AnimationClip[] FaceAnimations;

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GameObject[] WeaponPrefabs;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GameObject[] ShiledPrefabs;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public GameObject[] HeadPrefabs;
}
