using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001053 RID: 4179
	[Token(Token = "0x2000A9C")]
	public class PunchMachineCounter : FurnitureBreakConditions
	{
		// Token: 0x06006951 RID: 26961 RVA: 0x00024060 File Offset: 0x00022260
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x2083C60", Offset = "0x2083D61", VA = "0x2083C60", Slot = "7")]
		public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
		{
			return default(bool);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x2083E90", Offset = "0x2083F91", VA = "0x2083E90")]
		private void IncCount()
		{
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x2083F30", Offset = "0x2084031", VA = "0x2083F30", Slot = "11")]
		protected override void Awake()
		{
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06006954 RID: 26964 RVA: 0x00024078 File Offset: 0x00022278
		[Token(Token = "0x17000A8E")]
		public override Vector3 GetTakeLockonPos
		{
			[Token(Token = "0x60057C6")]
			[Address(RVA = "0x2083FA0", Offset = "0x20840A1", VA = "0x2083FA0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00024090 File Offset: 0x00022290
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x20840A0", Offset = "0x20841A1", VA = "0x20840A0", Slot = "9")]
		public override bool IsCanNotLockon(CharacterBase lockonCharacter)
		{
			return default(bool);
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x2084140", Offset = "0x2084241", VA = "0x2084140")]
		public PunchMachineCounter()
		{
		}

		// Token: 0x04017158 RID: 94552
		[Token(Token = "0x4013DBB")]
		private const int PUNCHCOUNT_MAX = 999999;
	}
}
