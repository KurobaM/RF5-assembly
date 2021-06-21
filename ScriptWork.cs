using System;
using Il2CppDummyDll;

// Token: 0x02000479 RID: 1145
[Token(Token = "0x2000372")]
public class ScriptWork
{
	// Token: 0x06001BCA RID: 7114 RVA: 0x0000C348 File Offset: 0x0000A548
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x21DE820", Offset = "0x21DE921", VA = "0x21DE820")]
	public bool LoadTextFile(byte[] byteWork)
	{
		return default(bool);
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x21DE920", Offset = "0x21DEA21", VA = "0x21DE920")]
	public void Reset()
	{
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x21DE930", Offset = "0x21DEA31", VA = "0x21DE930")]
	public void ForceEnd()
	{
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x0000C360 File Offset: 0x0000A560
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x21DE890", Offset = "0x21DE991", VA = "0x21DE890")]
	private int GetTextTableInt(int addr, int size)
	{
		return 0;
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x21DE940", Offset = "0x21DEA41", VA = "0x21DE940")]
	private string GetTextTableString(int addr, int len)
	{
		return null;
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x0000C378 File Offset: 0x0000A578
	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x21DEA80", Offset = "0x21DEB81", VA = "0x21DEA80")]
	public stCommand_t ReadNext()
	{
		return default(stCommand_t);
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x0000C390 File Offset: 0x0000A590
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x21DEEB0", Offset = "0x21DEFB1", VA = "0x21DEEB0")]
	public stCommand_t CommandSkip(CommandList cmd)
	{
		return default(stCommand_t);
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x21DEF40", Offset = "0x21DF041", VA = "0x21DEF40")]
	public ScriptWork()
	{
	}

	// Token: 0x04006186 RID: 24966
	[Token(Token = "0x4005D80")]
	[FieldOffset(Offset = "0x10")]
	private byte[] m_TextTableWork;

	// Token: 0x04006187 RID: 24967
	[Token(Token = "0x4005D81")]
	[FieldOffset(Offset = "0x18")]
	private int addr;

	// Token: 0x04006188 RID: 24968
	[Token(Token = "0x4005D82")]
	[FieldOffset(Offset = "0x20")]
	private stCommand_t command;

	// Token: 0x04006189 RID: 24969
	[Token(Token = "0x4005D83")]
	[FieldOffset(Offset = "0x38")]
	private int commandNum;

	// Token: 0x0400618A RID: 24970
	[Token(Token = "0x4005D84")]
	[FieldOffset(Offset = "0x3C")]
	private int commandIndex;

	// Token: 0x0400618B RID: 24971
	[Token(Token = "0x4005D85")]
	[FieldOffset(Offset = "0x40")]
	public string filePath;

	// Token: 0x0400618C RID: 24972
	[Token(Token = "0x4005D86")]
	[FieldOffset(Offset = "0x48")]
	private readonly int[][] CommandArgList;
}
