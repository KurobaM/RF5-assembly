using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B64 RID: 2916
[Token(Token = "0x200079A")]
public class LODSceneSelection : MonoBehaviour
{
	// Token: 0x06004AEC RID: 19180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC2")]
	[Address(RVA = "0x2300970", Offset = "0x2300A71", VA = "0x2300970")]
	private void OnGUI()
	{
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0x2300E40", Offset = "0x2300F41", VA = "0x2300E40")]
	public LODSceneSelection()
	{
	}

	// Token: 0x0400AB8B RID: 43915
	[Token(Token = "0x4008171")]
	[FieldOffset(Offset = "0x18")]
	public int BoxWidth;

	// Token: 0x0400AB8C RID: 43916
	[Token(Token = "0x4008172")]
	[FieldOffset(Offset = "0x1C")]
	public int BoxHeight;

	// Token: 0x0400AB8D RID: 43917
	[Token(Token = "0x4008173")]
	[FieldOffset(Offset = "0x20")]
	public int MarginH;

	// Token: 0x0400AB8E RID: 43918
	[Token(Token = "0x4008174")]
	[FieldOffset(Offset = "0x24")]
	public int MarginV;

	// Token: 0x0400AB8F RID: 43919
	[Token(Token = "0x4008175")]
	[FieldOffset(Offset = "0x28")]
	public LODSceneSelection.SceneOption[] SceneOptions;

	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x200134B")]
	[Serializable]
	public class SceneOption
	{
		// Token: 0x06004AEE RID: 19182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770D")]
		[Address(RVA = "0x2300E60", Offset = "0x2300F61", VA = "0x2300E60")]
		public SceneOption()
		{
		}

		// Token: 0x0400AB90 RID: 43920
		[Token(Token = "0x401B67B")]
		[FieldOffset(Offset = "0x10")]
		public string m_sceneName;

		// Token: 0x0400AB91 RID: 43921
		[Token(Token = "0x401B67C")]
		[FieldOffset(Offset = "0x18")]
		public string m_sceneDisplayName;
	}
}
