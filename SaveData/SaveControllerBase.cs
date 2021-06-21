using System;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EE6 RID: 3814
	[Token(Token = "0x20009C3")]
	public abstract class SaveControllerBase
	{
		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x00021720 File Offset: 0x0001F920
		[Token(Token = "0x17000A17")]
		public virtual bool IsBusy
		{
			[Token(Token = "0x60052DC")]
			[Address(RVA = "0x21CE9C0", Offset = "0x21CEAC1", VA = "0x21CE9C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060063CD RID: 25549
		[Token(Token = "0x60052DD")]
		public abstract string GetFilePath(string filename);

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063CF RID: 25551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A18")]
		public string FilePath
		{
			[Token(Token = "0x60052DE")]
			[Address(RVA = "0x21CE9D0", Offset = "0x21CEAD1", VA = "0x21CE9D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA20", Offset = "0x1ACB21")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052DF")]
			[Address(RVA = "0x21CE9E0", Offset = "0x21CEAE1", VA = "0x21CE9E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA30", Offset = "0x1ACB31")]
			protected set
			{
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060063D0 RID: 25552 RVA: 0x00021738 File Offset: 0x0001F938
		// (set) Token: 0x060063D1 RID: 25553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A19")]
		public ErrorCode ErrorCode
		{
			[Token(Token = "0x60052E0")]
			[Address(RVA = "0x21CE9F0", Offset = "0x21CEAF1", VA = "0x21CE9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA40", Offset = "0x1ACB41")]
			get
			{
				return ErrorCode.NONE;
			}
			[Token(Token = "0x60052E1")]
			[Address(RVA = "0x21CEA00", Offset = "0x21CEB01", VA = "0x21CEA00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA50", Offset = "0x1ACB51")]
			protected set
			{
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063D3 RID: 25555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1A")]
		public string ErrorResult
		{
			[Token(Token = "0x60052E2")]
			[Address(RVA = "0x21CEA10", Offset = "0x21CEB11", VA = "0x21CEA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA60", Offset = "0x1ACB61")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052E3")]
			[Address(RVA = "0x21CEA20", Offset = "0x21CEB21", VA = "0x21CEA20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA70", Offset = "0x1ACB71")]
			protected set
			{
			}
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x21CEA30", Offset = "0x21CEB31", VA = "0x21CEA30")]
		public void ErrorSet(ErrorCode errorCode, string errorResult)
		{
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x21CEA40", Offset = "0x21CEB41", VA = "0x21CEA40")]
		public void Save(SaveDataBase savedata)
		{
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x21CEAC0", Offset = "0x21CEBC1", VA = "0x21CEAC0")]
		public void Load(SaveDataBase savedata)
		{
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x21CEB40", Offset = "0x21CEC41", VA = "0x21CEB40")]
		public void Delete(SaveDataBase savedata)
		{
		}

		// Token: 0x060063D8 RID: 25560
		[Token(Token = "0x60052E8")]
		public abstract void Create();

		// Token: 0x060063D9 RID: 25561
		[Token(Token = "0x60052E9")]
		public abstract void Destroy();

		// Token: 0x060063DA RID: 25562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x21CEB70", Offset = "0x21CEC71", VA = "0x21CEB70", Slot = "8")]
		public virtual void Update()
		{
		}

		// Token: 0x060063DB RID: 25563
		[Token(Token = "0x60052EB")]
		public abstract void SaveData(string filename, byte[] savedata);

		// Token: 0x060063DC RID: 25564
		[Token(Token = "0x60052EC")]
		public abstract void LoadData(string filename, out byte[] savedata);

		// Token: 0x060063DD RID: 25565
		[Token(Token = "0x60052ED")]
		public abstract void DeleteData(string filename);

		// Token: 0x060063DE RID: 25566
		[Token(Token = "0x60052EE")]
		public abstract bool IsExisting(ulong applicationId);

		// Token: 0x060063DF RID: 25567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x21CEC70", Offset = "0x21CED71", VA = "0x21CEC70")]
		protected SaveControllerBase()
		{
		}

		// Token: 0x0400C3BA RID: 50106
		[Token(Token = "0x400929F")]
		[FieldOffset(Offset = "0x10")]
		protected SaveControllerBase.STATE State;

		// Token: 0x0400C3BB RID: 50107
		[Token(Token = "0x40092A0")]
		[FieldOffset(Offset = "0x18")]
		protected SaveDataBase TargetData;

		// Token: 0x0400C3BC RID: 50108
		[Token(Token = "0x40092A1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F330", Offset = "0x17F431")]
		private string <FilePath>k__BackingField;

		// Token: 0x0400C3BD RID: 50109
		[Token(Token = "0x40092A2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F340", Offset = "0x17F441")]
		private ErrorCode <ErrorCode>k__BackingField;

		// Token: 0x0400C3BE RID: 50110
		[Token(Token = "0x40092A3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F350", Offset = "0x17F451")]
		private string <ErrorResult>k__BackingField;

		// Token: 0x02000EE7 RID: 3815
		[Token(Token = "0x200148F")]
		public enum STATE
		{
			// Token: 0x0400C3C0 RID: 50112
			[Token(Token = "0x401BD28")]
			IDLE,
			// Token: 0x0400C3C1 RID: 50113
			[Token(Token = "0x401BD29")]
			INIT,
			// Token: 0x0400C3C2 RID: 50114
			[Token(Token = "0x401BD2A")]
			LOAD,
			// Token: 0x0400C3C3 RID: 50115
			[Token(Token = "0x401BD2B")]
			SAVE,
			// Token: 0x0400C3C4 RID: 50116
			[Token(Token = "0x401BD2C")]
			END
		}
	}
}
