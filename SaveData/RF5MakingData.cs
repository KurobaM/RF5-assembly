using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED4 RID: 3796
	[Token(Token = "0x20009B6")]
	public class RF5MakingData : SaveDataValueBase
	{
		// Token: 0x0600633C RID: 25404 RVA: 0x000214C8 File Offset: 0x0001F6C8
		[Token(Token = "0x600524D")]
		[Address(RVA = "0x1F03650", Offset = "0x1F03751", VA = "0x1F03650")]
		public bool GetSaveFlag(int id)
		{
			return default(bool);
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524E")]
		[Address(RVA = "0x1F03670", Offset = "0x1F03771", VA = "0x1F03670")]
		public void SetSaveFlag(int id, bool value)
		{
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[Token(Token = "0x600524F")]
		[Address(RVA = "0x1F03690", Offset = "0x1F03791", VA = "0x1F03690")]
		public bool GetEndScriptFlag(RF5MakingData.END_SCRIPT_FLAG id)
		{
			return default(bool);
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x1F036B0", Offset = "0x1F037B1", VA = "0x1F036B0")]
		public void SetEndScriptFlag(RF5MakingData.END_SCRIPT_FLAG id, bool value)
		{
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x1F036D0", Offset = "0x1F037D1", VA = "0x1F036D0")]
		public RF5MakingData()
		{
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x1F03790", Offset = "0x1F03891", VA = "0x1F03790", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x1F037D0", Offset = "0x1F038D1", VA = "0x1F037D0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x1F037E0", Offset = "0x1F038E1", VA = "0x1F037E0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x1F03850", Offset = "0x1F03951", VA = "0x1F03850", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x1F038C0", Offset = "0x1F039C1", VA = "0x1F038C0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C310 RID: 49936
		[Token(Token = "0x400922B")]
		[FieldOffset(Offset = "0x10")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x0400C311 RID: 49937
		[Token(Token = "0x400922C")]
		[FieldOffset(Offset = "0x18")]
		public int EnemyLevelupStage;

		// Token: 0x0400C312 RID: 49938
		[Token(Token = "0x400922D")]
		[FieldOffset(Offset = "0x1C")]
		public int MakingCount;

		// Token: 0x0400C313 RID: 49939
		[Token(Token = "0x400922E")]
		[FieldOffset(Offset = "0x20")]
		public SaveFlagStorage DoEndScriptFlags;

		// Token: 0x02000ED5 RID: 3797
		[Token(Token = "0x200148A")]
		public enum END_SCRIPT_FLAG
		{
			// Token: 0x0400C315 RID: 49941
			[Token(Token = "0x401BCF2")]
			STORYCLEAR,
			// Token: 0x0400C316 RID: 49942
			[Token(Token = "0x401BCF3")]
			ALLORDER,
			// Token: 0x0400C317 RID: 49943
			[Token(Token = "0x401BCF4")]
			MARRY,
			// Token: 0x0400C318 RID: 49944
			[Token(Token = "0x401BCF5")]
			CHILD,
			// Token: 0x0400C319 RID: 49945
			[Token(Token = "0x401BCF6")]
			COUNT_5,
			// Token: 0x0400C31A RID: 49946
			[Token(Token = "0x401BCF7")]
			COUNT_10,
			// Token: 0x0400C31B RID: 49947
			[Token(Token = "0x401BCF8")]
			COUNT_30,
			// Token: 0x0400C31C RID: 49948
			[Token(Token = "0x401BCF9")]
			COUNT_50,
			// Token: 0x0400C31D RID: 49949
			[Token(Token = "0x401BCFA")]
			COUNT_70,
			// Token: 0x0400C31E RID: 49950
			[Token(Token = "0x401BCFB")]
			COUNT_100,
			// Token: 0x0400C31F RID: 49951
			[Token(Token = "0x401BCFC")]
			Length
		}
	}
}
