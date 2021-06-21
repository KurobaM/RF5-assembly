using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001044 RID: 4164
	[Token(Token = "0x2000A93")]
	public class FurnitureBreakConditions : CharacterBase
	{
		// Token: 0x0600689E RID: 26782 RVA: 0x00023C88 File Offset: 0x00021E88
		[Token(Token = "0x6005722")]
		[Address(RVA = "0x2076C10", Offset = "0x2076D11", VA = "0x2076C10", Slot = "7")]
		public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
		{
			return default(bool);
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005723")]
		[Address(RVA = "0x2077120", Offset = "0x2077221", VA = "0x2077120", Slot = "11")]
		protected override void Awake()
		{
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[Token(Token = "0x17000A7D")]
		public override Vector3 GetTakeLockonPos
		{
			[Token(Token = "0x6005724")]
			[Address(RVA = "0x2077190", Offset = "0x2077291", VA = "0x2077190", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00023CB8 File Offset: 0x00021EB8
		[Token(Token = "0x6005725")]
		[Address(RVA = "0x20771F0", Offset = "0x20772F1", VA = "0x20771F0", Slot = "9")]
		public override bool IsCanNotLockon(CharacterBase lockonCharacter)
		{
			return default(bool);
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005726")]
		[Address(RVA = "0x20772F0", Offset = "0x20773F1", VA = "0x20772F0")]
		public FurnitureBreakConditions()
		{
		}

		// Token: 0x040170FE RID: 94462
		[Token(Token = "0x4013D7C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public AttackType attackType;

		// Token: 0x040170FF RID: 94463
		[Token(Token = "0x4013D7D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public AttackAttribute[] attackAttribute;

		// Token: 0x04017100 RID: 94464
		[Token(Token = "0x4013D7E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public int Hp;

		// Token: 0x04017101 RID: 94465
		[Token(Token = "0x4013D7F")]
		[FieldOffset(Offset = "0x78")]
		private StorageFurniture Owner;
	}
}
