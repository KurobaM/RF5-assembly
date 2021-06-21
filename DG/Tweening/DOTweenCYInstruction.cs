using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200163F RID: 5695
	[Token(Token = "0x2000F82")]
	public static class DOTweenCYInstruction
	{
		// Token: 0x02001640 RID: 5696
		[Token(Token = "0x200160E")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x0600814E RID: 33102 RVA: 0x0002E800 File Offset: 0x0002CA00
			[Token(Token = "0x17000F51")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600808C")]
				[Address(RVA = "0x20EEBF0", Offset = "0x20EECF1", VA = "0x20EEBF0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600814F RID: 33103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600808D")]
			[Address(RVA = "0x20EEC30", Offset = "0x20EED31", VA = "0x20EEC30")]
			public WaitForCompletion(Tween tween)
			{
			}

			// Token: 0x0401C201 RID: 115201
			[Token(Token = "0x401C3E3")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x02001641 RID: 5697
		[Token(Token = "0x200160F")]
		public class WaitForRewind : CustomYieldInstruction
		{
			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x06008150 RID: 33104 RVA: 0x0002E818 File Offset: 0x0002CA18
			[Token(Token = "0x17000F52")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600808E")]
				[Address(RVA = "0x20EEE40", Offset = "0x20EEF41", VA = "0x20EEE40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06008151 RID: 33105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600808F")]
			[Address(RVA = "0x20EEEC0", Offset = "0x20EEFC1", VA = "0x20EEEC0")]
			public WaitForRewind(Tween tween)
			{
			}

			// Token: 0x0401C202 RID: 115202
			[Token(Token = "0x401C3E4")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x02001642 RID: 5698
		[Token(Token = "0x2001610")]
		public class WaitForKill : CustomYieldInstruction
		{
			// Token: 0x17000F89 RID: 3977
			// (get) Token: 0x06008152 RID: 33106 RVA: 0x0002E830 File Offset: 0x0002CA30
			[Token(Token = "0x17000F53")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6008090")]
				[Address(RVA = "0x20EED20", Offset = "0x20EEE21", VA = "0x20EED20", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06008153 RID: 33107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008091")]
			[Address(RVA = "0x20EED40", Offset = "0x20EEE41", VA = "0x20EED40")]
			public WaitForKill(Tween tween)
			{
			}

			// Token: 0x0401C203 RID: 115203
			[Token(Token = "0x401C3E5")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x02001643 RID: 5699
		[Token(Token = "0x2001611")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			// Token: 0x17000F8A RID: 3978
			// (get) Token: 0x06008154 RID: 33108 RVA: 0x0002E848 File Offset: 0x0002CA48
			[Token(Token = "0x17000F54")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6008092")]
				[Address(RVA = "0x20EEC70", Offset = "0x20EED71", VA = "0x20EEC70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06008155 RID: 33109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008093")]
			[Address(RVA = "0x20EECD0", Offset = "0x20EEDD1", VA = "0x20EECD0")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}

			// Token: 0x0401C204 RID: 115204
			[Token(Token = "0x401C3E6")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			// Token: 0x0401C205 RID: 115205
			[Token(Token = "0x401C3E7")]
			[FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;
		}

		// Token: 0x02001644 RID: 5700
		[Token(Token = "0x2001612")]
		public class WaitForPosition : CustomYieldInstruction
		{
			// Token: 0x17000F8B RID: 3979
			// (get) Token: 0x06008156 RID: 33110 RVA: 0x0002E860 File Offset: 0x0002CA60
			[Token(Token = "0x17000F55")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6008094")]
				[Address(RVA = "0x20EED80", Offset = "0x20EEE81", VA = "0x20EED80", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06008157 RID: 33111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008095")]
			[Address(RVA = "0x20EEDF0", Offset = "0x20EEEF1", VA = "0x20EEDF0")]
			public WaitForPosition(Tween tween, float position)
			{
			}

			// Token: 0x0401C206 RID: 115206
			[Token(Token = "0x401C3E8")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			// Token: 0x0401C207 RID: 115207
			[Token(Token = "0x401C3E9")]
			[FieldOffset(Offset = "0x18")]
			private readonly float position;
		}

		// Token: 0x02001645 RID: 5701
		[Token(Token = "0x2001613")]
		public class WaitForStart : CustomYieldInstruction
		{
			// Token: 0x17000F8C RID: 3980
			// (get) Token: 0x06008158 RID: 33112 RVA: 0x0002E878 File Offset: 0x0002CA78
			[Token(Token = "0x17000F56")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6008096")]
				[Address(RVA = "0x20EEF00", Offset = "0x20EF001", VA = "0x20EEF00", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06008159 RID: 33113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008097")]
			[Address(RVA = "0x20EEF40", Offset = "0x20EF041", VA = "0x20EEF40")]
			public WaitForStart(Tween tween)
			{
			}

			// Token: 0x0401C208 RID: 115208
			[Token(Token = "0x401C3EA")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}
	}
}
