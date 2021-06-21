using System;
using Il2CppDummyDll;

// Token: 0x02000267 RID: 615
[Token(Token = "0x20001E9")]
public class ActionSpeedManager : SingletonMonoBehaviour<ActionSpeedManager>
{
	// Token: 0x06000F2D RID: 3885 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x1D45F70", Offset = "0x1D46071", VA = "0x1D45F70")]
	public bool Regist(Character chara, ActionSpeedController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x1D45FE0", Offset = "0x1D460E1", VA = "0x1D45FE0")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x1D46050", Offset = "0x1D46151", VA = "0x1D46050")]
	public ActionSpeedController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x1D46100", Offset = "0x1D46201", VA = "0x1D46100")]
	private void Update()
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00006C90 File Offset: 0x00004E90
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x1D46260", Offset = "0x1D46361", VA = "0x1D46260")]
	public float Speed(Character chara)
	{
		return 0f;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00006CA8 File Offset: 0x00004EA8
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x1D45C20", Offset = "0x1D45D21", VA = "0x1D45C20")]
	public bool DoPlay(Character chara, float rate, float duration)
	{
		return default(bool);
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00006CC0 File Offset: 0x00004EC0
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x1D46380", Offset = "0x1D46481", VA = "0x1D46380")]
	public bool DoStop(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x1D464B0", Offset = "0x1D465B1", VA = "0x1D464B0")]
	public ActionSpeedManager()
	{
	}

	// Token: 0x040008C7 RID: 2247
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, ActionSpeedController> m_Register;
}
