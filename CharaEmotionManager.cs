using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;

// Token: 0x0200026E RID: 622
[Token(Token = "0x20001EF")]
public class CharaEmotionManager : SingletonMonoBehaviour<CharaEmotionManager>
{
	// Token: 0x06000F78 RID: 3960 RVA: 0x00006F78 File Offset: 0x00005178
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x1E82B20", Offset = "0x1E82C21", VA = "0x1E82B20")]
	public bool Regist(CharacterBase chara, EmotionController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00006F90 File Offset: 0x00005190
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x1E82B90", Offset = "0x1E82C91", VA = "0x1E82B90")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x1E82C00", Offset = "0x1E82D01", VA = "0x1E82C00")]
	public EmotionController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00006FA8 File Offset: 0x000051A8
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x1E82CB0", Offset = "0x1E82DB1", VA = "0x1E82CB0")]
	public bool IsPlaying(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00006FC0 File Offset: 0x000051C0
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x1E82DD0", Offset = "0x1E82ED1", VA = "0x1E82DD0")]
	public EmotionType CurrentEmotionType(CharacterBase chara)
	{
		return EmotionType.None;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00006FD8 File Offset: 0x000051D8
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x1E82EF0", Offset = "0x1E82FF1", VA = "0x1E82EF0")]
	public bool DoPlay(CharacterBase chara, EmotionType emotionType, [Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00006FF0 File Offset: 0x000051F0
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x1E83030", Offset = "0x1E83131", VA = "0x1E83030")]
	public bool DoStop(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x1E83150", Offset = "0x1E83251", VA = "0x1E83150")]
	public void DoStopAll()
	{
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x1E83270", Offset = "0x1E83371", VA = "0x1E83270")]
	public CharaEmotionManager()
	{
	}

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, EmotionController> m_Register;
}
