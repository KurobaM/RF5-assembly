using System;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EE2 RID: 3810
	[Token(Token = "0x20009C1")]
	public class SteamSaveController : SaveControllerBase
	{
		// Token: 0x060063B5 RID: 25525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x21D2990", Offset = "0x21D2A91", VA = "0x21D2990", Slot = "5")]
		public override string GetFilePath(string filename)
		{
			return null;
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x21D2A50", Offset = "0x21D2B51", VA = "0x21D2A50", Slot = "6")]
		public override void Create()
		{
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x21D2A60", Offset = "0x21D2B61", VA = "0x21D2A60", Slot = "7")]
		public override void Destroy()
		{
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x21D2A70", Offset = "0x21D2B71", VA = "0x21D2A70", Slot = "9")]
		public override void SaveData(string filename, byte[] savedata)
		{
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x21D2C90", Offset = "0x21D2D91", VA = "0x21D2C90", Slot = "10")]
		public override void LoadData(string filename, out byte[] savedata)
		{
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x21D2EE0", Offset = "0x21D2FE1", VA = "0x21D2EE0", Slot = "11")]
		public override void DeleteData(string filename)
		{
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x000216C0 File Offset: 0x0001F8C0
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x21D2FF0", Offset = "0x21D30F1", VA = "0x21D2FF0", Slot = "12")]
		public override bool IsExisting(ulong applicationId)
		{
			return default(bool);
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x21D3000", Offset = "0x21D3101", VA = "0x21D3000")]
		public SteamSaveController()
		{
		}

		// Token: 0x0400C3A2 RID: 50082
		[Token(Token = "0x4009297")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string SavePath;

		// Token: 0x0400C3A3 RID: 50083
		[Token(Token = "0x4009298")]
		public const string SaveDir = "SaveData";

		// Token: 0x0400C3A4 RID: 50084
		[Token(Token = "0x4009299")]
		public const string SaveExt = ".dat";
	}
}
