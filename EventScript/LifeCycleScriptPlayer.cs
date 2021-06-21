using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010E6 RID: 4326
	[Token(Token = "0x2000ADC")]
	public class LifeCycleScriptPlayer : ScriptPlayer
	{
		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06006D9A RID: 28058 RVA: 0x00025BD8 File Offset: 0x00023DD8
		// (set) Token: 0x06006D9B RID: 28059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE3")]
		public bool IsLoaded
		{
			[Token(Token = "0x6005AE5")]
			[Address(RVA = "0x21B98D0", Offset = "0x21B99D1", VA = "0x21B98D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE930", Offset = "0x1AEA31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AE6")]
			[Address(RVA = "0x21B98E0", Offset = "0x21B99E1", VA = "0x21B98E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE940", Offset = "0x1AEA41")]
			set
			{
			}
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0x21B8C50", Offset = "0x21B8D51", VA = "0x21B8C50")]
		public LifeCycleScriptPlayer()
		{
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0x21B9930", Offset = "0x21B9A31", VA = "0x21B9930")]
		public LifeCycleScriptPlayer(string name, [Optional] Action cb_end)
		{
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0x21B9A00", Offset = "0x21B9B01", VA = "0x21B9A00", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0x21B9AB0", Offset = "0x21B9BB1", VA = "0x21B9AB0", Slot = "9")]
		public override void End()
		{
		}

		// Token: 0x0401753D RID: 95549
		[Token(Token = "0x401401F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811D0", Offset = "0x1812D1")]
		private bool <IsLoaded>k__BackingField;

		// Token: 0x0401753E RID: 95550
		[Token(Token = "0x4014020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string TS_Name;

		// Token: 0x0401753F RID: 95551
		[Token(Token = "0x4014021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int TS_LoadId;

		// Token: 0x04017540 RID: 95552
		[Token(Token = "0x4014022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ActorID TS_ActorID;

		// Token: 0x04017541 RID: 95553
		[Token(Token = "0x4014023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NPCID TS_NpcID;

		// Token: 0x04017542 RID: 95554
		[Token(Token = "0x4014024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Place Home;

		// Token: 0x04017543 RID: 95555
		[Token(Token = "0x4014025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string HomeSleepPoint;

		// Token: 0x04017544 RID: 95556
		[Token(Token = "0x4014026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string HomeSitPoint;
	}
}
