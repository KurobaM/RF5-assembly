using System;
using System.Runtime.InteropServices;
using BinaryStream;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010E8 RID: 4328
	[Token(Token = "0x2000ADE")]
	public class ScriptPlayer
	{
		// Token: 0x06006DA1 RID: 28065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0x21B98F0", Offset = "0x21B99F1", VA = "0x21B98F0")]
		public ScriptPlayer()
		{
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AED")]
		[Address(RVA = "0x21B99A0", Offset = "0x21B9AA1", VA = "0x21B99A0")]
		public ScriptPlayer(string name, [Optional] Action cb_end)
		{
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0x21BA590", Offset = "0x21BA691", VA = "0x21BA590", Slot = "4")]
		protected virtual void Init()
		{
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0x21BA5F0", Offset = "0x21BA6F1", VA = "0x21BA5F0", Slot = "5")]
		public virtual void Load(string name, [Optional] Action cb_end)
		{
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0x21BA6C0", Offset = "0x21BA7C1", VA = "0x21BA6C0", Slot = "6")]
		public virtual void SetData(byte[] data)
		{
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0x21BA740", Offset = "0x21BA841", VA = "0x21BA740", Slot = "7")]
		public virtual void Clear()
		{
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0x21B9A60", Offset = "0x21B9B61", VA = "0x21B9A60", Slot = "8")]
		public virtual void Start()
		{
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0x21B9AF0", Offset = "0x21B9BF1", VA = "0x21B9AF0", Slot = "9")]
		public virtual void End()
		{
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x00025BF0 File Offset: 0x00023DF0
		[Token(Token = "0x17000AE4")]
		public bool Ready
		{
			[Token(Token = "0x6005AF4")]
			[Address(RVA = "0x21B8FF0", Offset = "0x21B90F1", VA = "0x21B8FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x00025C08 File Offset: 0x00023E08
		// (set) Token: 0x06006DAB RID: 28075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE5")]
		public bool Active
		{
			[Token(Token = "0x6005AF5")]
			[Address(RVA = "0x21BA7A0", Offset = "0x21BA8A1", VA = "0x21BA7A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE950", Offset = "0x1AEA51")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AF6")]
			[Address(RVA = "0x21BA7B0", Offset = "0x21BA8B1", VA = "0x21BA7B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE960", Offset = "0x1AEA61")]
			private set
			{
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06006DAC RID: 28076 RVA: 0x00025C20 File Offset: 0x00023E20
		// (set) Token: 0x06006DAD RID: 28077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE6")]
		public bool Exit
		{
			[Token(Token = "0x6005AF7")]
			[Address(RVA = "0x21BA7C0", Offset = "0x21BA8C1", VA = "0x21BA7C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE970", Offset = "0x1AEA71")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AF8")]
			[Address(RVA = "0x21BA7D0", Offset = "0x21BA8D1", VA = "0x21BA7D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE980", Offset = "0x1AEA81")]
			set
			{
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x00025C38 File Offset: 0x00023E38
		// (set) Token: 0x06006DAF RID: 28079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE7")]
		public bool Pause
		{
			[Token(Token = "0x6005AF9")]
			[Address(RVA = "0x21BA7E0", Offset = "0x21BA8E1", VA = "0x21BA7E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE990", Offset = "0x1AEA91")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AFA")]
			[Address(RVA = "0x21BA7F0", Offset = "0x21BA8F1", VA = "0x21BA7F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE9A0", Offset = "0x1AEAA1")]
			set
			{
			}
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x21BA760", Offset = "0x21BA861", VA = "0x21BA760")]
		public void SetPos(int pos)
		{
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0x21B9010", Offset = "0x21B9111", VA = "0x21B9010")]
		public void Update()
		{
		}

		// Token: 0x04017546 RID: 95558
		[Token(Token = "0x4014028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float WaitTime;

		// Token: 0x04017547 RID: 95559
		[Token(Token = "0x4014029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BinaryReader bin_;

		// Token: 0x04017548 RID: 95560
		[Token(Token = "0x401402A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CommandBase now_;

		// Token: 0x04017549 RID: 95561
		[Token(Token = "0x401402B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action cb_end_;

		// Token: 0x0401754A RID: 95562
		[Token(Token = "0x401402C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool reader_start;

		// Token: 0x0401754B RID: 95563
		[Token(Token = "0x401402D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool first_;

		// Token: 0x0401754C RID: 95564
		[Token(Token = "0x401402E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811E0", Offset = "0x1812E1")]
		private bool <Active>k__BackingField;

		// Token: 0x0401754D RID: 95565
		[Token(Token = "0x401402F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811F0", Offset = "0x1812F1")]
		private bool <Exit>k__BackingField;

		// Token: 0x0401754E RID: 95566
		[Token(Token = "0x4014030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181200", Offset = "0x181301")]
		private bool <Pause>k__BackingField;
	}
}
