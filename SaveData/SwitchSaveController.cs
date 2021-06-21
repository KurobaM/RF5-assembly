using System;
using Il2CppDummyDll;
using nn;
using nn.account;
using nn.fs;

namespace SaveData
{
	// Token: 0x02000EE3 RID: 3811
	[Token(Token = "0x20009C2")]
	public class SwitchSaveController : SaveControllerBase
	{
		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x000216D8 File Offset: 0x0001F8D8
		// (set) Token: 0x060063BF RID: 25535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A16")]
		public bool IsMount
		{
			[Token(Token = "0x60052CF")]
			[Address(RVA = "0x21D3070", Offset = "0x21D3171", VA = "0x21D3070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA00", Offset = "0x1ACB01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60052D0")]
			[Address(RVA = "0x21D3080", Offset = "0x21D3181", VA = "0x21D3080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA10", Offset = "0x1ACB11")]
			private set
			{
			}
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x000216F0 File Offset: 0x0001F8F0
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x21D3090", Offset = "0x21D3191", VA = "0x21D3090")]
		private bool GetError(Result result)
		{
			return default(bool);
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x21D3210", Offset = "0x21D3311", VA = "0x21D3210", Slot = "5")]
		public override string GetFilePath(string filename)
		{
			return null;
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x21D3270", Offset = "0x21D3371", VA = "0x21D3270", Slot = "6")]
		public override void Create()
		{
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x21D34B0", Offset = "0x21D35B1", VA = "0x21D34B0", Slot = "7")]
		public override void Destroy()
		{
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x21D3410", Offset = "0x21D3511", VA = "0x21D3410")]
		private void Mount()
		{
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x21D3510", Offset = "0x21D3611", VA = "0x21D3510")]
		private void UnMount()
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x21D3570", Offset = "0x21D3671", VA = "0x21D3570", Slot = "9")]
		public override void SaveData(string filename, byte[] savedata)
		{
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x21D37C0", Offset = "0x21D38C1", VA = "0x21D37C0", Slot = "10")]
		public override void LoadData(string filename, out byte[] savedata)
		{
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x21D3990", Offset = "0x21D3A91", VA = "0x21D3990", Slot = "11")]
		public override void DeleteData(string filename)
		{
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00021708 File Offset: 0x0001F908
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x21D3AE0", Offset = "0x21D3BE1", VA = "0x21D3AE0", Slot = "12")]
		public override bool IsExisting(ulong applicationId)
		{
			return default(bool);
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x21D1C10", Offset = "0x21D1D11", VA = "0x21D1C10")]
		public SwitchSaveController()
		{
		}

		// Token: 0x0400C3A5 RID: 50085
		[Token(Token = "0x400929A")]
		[FieldOffset(Offset = "0x38")]
		private Uid UserId;

		// Token: 0x0400C3A6 RID: 50086
		[Token(Token = "0x400929B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F320", Offset = "0x17F421")]
		private bool <IsMount>k__BackingField;

		// Token: 0x0400C3A7 RID: 50087
		[Token(Token = "0x400929C")]
		private const string MountName = "save";

		// Token: 0x0400C3A8 RID: 50088
		[Token(Token = "0x400929D")]
		[FieldOffset(Offset = "0x50")]
		private FileHandle FileHandle;

		// Token: 0x0400C3A9 RID: 50089
		[Token(Token = "0x400929E")]
		[FieldOffset(Offset = "0x58")]
		private SwitchSaveController.ErrorCheckData[] ErrorCheckDatas;

		// Token: 0x02000EE4 RID: 3812
		[Token(Token = "0x200148D")]
		private enum ResultType
		{
			// Token: 0x0400C3AB RID: 50091
			[Token(Token = "0x401BD18")]
			ResultPathNotFound,
			// Token: 0x0400C3AC RID: 50092
			[Token(Token = "0x401BD19")]
			ResultUsableSpaceNotEnough,
			// Token: 0x0400C3AD RID: 50093
			[Token(Token = "0x401BD1A")]
			ResultPathAlreadyExists,
			// Token: 0x0400C3AE RID: 50094
			[Token(Token = "0x401BD1B")]
			ResultTargetLocked,
			// Token: 0x0400C3AF RID: 50095
			[Token(Token = "0x401BD1C")]
			ResultDirectoryNotEmpty,
			// Token: 0x0400C3B0 RID: 50096
			[Token(Token = "0x401BD1D")]
			ResultDirectoryStatusChanged,
			// Token: 0x0400C3B1 RID: 50097
			[Token(Token = "0x401BD1E")]
			ResultHandledByAllProcess,
			// Token: 0x0400C3B2 RID: 50098
			[Token(Token = "0x401BD1F")]
			ResultMountNameAlreadyExists,
			// Token: 0x0400C3B3 RID: 50099
			[Token(Token = "0x401BD20")]
			ResultTargetNotFound,
			// Token: 0x0400C3B4 RID: 50100
			[Token(Token = "0x401BD21")]
			ResultUnsupportedSdkVersion,
			// Token: 0x0400C3B5 RID: 50101
			[Token(Token = "0x401BD22")]
			Length
		}

		// Token: 0x02000EE5 RID: 3813
		[Token(Token = "0x200148E")]
		private class ErrorCheckData
		{
			// Token: 0x060063CB RID: 25547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B9E")]
			[Address(RVA = "0x21D3B00", Offset = "0x21D3C01", VA = "0x21D3B00")]
			public ErrorCheckData()
			{
			}

			// Token: 0x0400C3B6 RID: 50102
			[Token(Token = "0x401BD23")]
			[FieldOffset(Offset = "0x10")]
			public ErrorCode errorCode;

			// Token: 0x0400C3B7 RID: 50103
			[Token(Token = "0x401BD24")]
			[FieldOffset(Offset = "0x14")]
			public SwitchSaveController.ResultType resultType;

			// Token: 0x0400C3B8 RID: 50104
			[Token(Token = "0x401BD25")]
			[FieldOffset(Offset = "0x18")]
			public Func<Result, bool> resultFunc;

			// Token: 0x0400C3B9 RID: 50105
			[Token(Token = "0x401BD26")]
			[FieldOffset(Offset = "0x20")]
			public bool isAbort;
		}
	}
}
