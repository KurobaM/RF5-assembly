using System;
using BinaryStream;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010DB RID: 4315
	[Token(Token = "0x2000AD4")]
	public class LoadTS : CommandBase
	{
		// Token: 0x06006D6B RID: 28011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x21B9B10", Offset = "0x21B9C11", VA = "0x21B9B10", Slot = "4")]
		public override void Start(BinaryReader reader, ScriptPlayer player)
		{
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x00025B60 File Offset: 0x00023D60
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x21B9D10", Offset = "0x21B9E11", VA = "0x21B9D10", Slot = "5")]
		public override bool Update(BinaryReader reader, ScriptPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x21B9D90", Offset = "0x21B9E91", VA = "0x21B9D90")]
		public LoadTS()
		{
		}

		// Token: 0x020010DC RID: 4316
		[Token(Token = "0x2001573")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0C0", Offset = "0x15A1C1")]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06006D6E RID: 28014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D5E")]
			[Address(RVA = "0x21B9D00", Offset = "0x21B9E01", VA = "0x21B9D00")]
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x06006D6F RID: 28015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D5F")]
			[Address(RVA = "0x21B9DA0", Offset = "0x21B9EA1", VA = "0x21B9DA0")]
			internal void <Start>b__0()
			{
			}

			// Token: 0x04017532 RID: 95538
			[Token(Token = "0x401C124")]
			[FieldOffset(Offset = "0x10")]
			public LifeCycleScriptPlayer lc_player;
		}
	}
}
