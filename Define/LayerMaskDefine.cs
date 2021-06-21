using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace Define
{
	// Token: 0x02001234 RID: 4660
	[Token(Token = "0x2000C08")]
	public static class LayerMaskDefine
	{
		// Token: 0x02001235 RID: 4661
		[Token(Token = "0x2001598")]
		public static class Layer
		{
			// Token: 0x04019B69 RID: 105321
			[Token(Token = "0x401C1A3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int Default;

			// Token: 0x04019B6A RID: 105322
			[Token(Token = "0x401C1A4")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int Character;

			// Token: 0x04019B6B RID: 105323
			[Token(Token = "0x401C1A5")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int NpcCharacter;

			// Token: 0x04019B6C RID: 105324
			[Token(Token = "0x401C1A6")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int IgnoreCharacter;

			// Token: 0x04019B6D RID: 105325
			[Token(Token = "0x401C1A7")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int OnlyCharacter;

			// Token: 0x04019B6E RID: 105326
			[Token(Token = "0x401C1A8")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int Attack;

			// Token: 0x04019B6F RID: 105327
			[Token(Token = "0x401C1A9")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int Bullet;
		}

		// Token: 0x02001236 RID: 4662
		[Token(Token = "0x2001599")]
		public static class Mask
		{
			// Token: 0x04019B70 RID: 105328
			[Token(Token = "0x401C1AA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LayerMask WorldStatic;

			// Token: 0x04019B71 RID: 105329
			[Token(Token = "0x401C1AB")]
			[FieldOffset(Offset = "0x4")]
			public static readonly LayerMask Wall;

			// Token: 0x04019B72 RID: 105330
			[Token(Token = "0x401C1AC")]
			[FieldOffset(Offset = "0x8")]
			public static LayerMask Floor;

			// Token: 0x04019B73 RID: 105331
			[Token(Token = "0x401C1AD")]
			[FieldOffset(Offset = "0xC")]
			public static readonly LayerMask CharacterBase;

			// Token: 0x04019B74 RID: 105332
			[Token(Token = "0x401C1AE")]
			[FieldOffset(Offset = "0x10")]
			public static readonly LayerMask OtherCharacter;

			// Token: 0x04019B75 RID: 105333
			[Token(Token = "0x401C1AF")]
			[FieldOffset(Offset = "0x14")]
			public static readonly LayerMask BulletHit;

			// Token: 0x04019B76 RID: 105334
			[Token(Token = "0x401C1B0")]
			[FieldOffset(Offset = "0x18")]
			public static readonly LayerMask IgnoreCharacter;

			// Token: 0x04019B77 RID: 105335
			[Token(Token = "0x401C1B1")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly LayerMask GrounderIKSolvers;

			// Token: 0x04019B78 RID: 105336
			[Token(Token = "0x401C1B2")]
			[FieldOffset(Offset = "0x20")]
			public static readonly LayerMask Wki;

			// Token: 0x04019B79 RID: 105337
			[Token(Token = "0x401C1B3")]
			[FieldOffset(Offset = "0x24")]
			public static readonly LayerMask OnlyCharacter;

			// Token: 0x04019B7A RID: 105338
			[Token(Token = "0x401C1B4")]
			[FieldOffset(Offset = "0x28")]
			public static readonly LayerMask Furniture;

			// Token: 0x04019B7B RID: 105339
			[Token(Token = "0x401C1B5")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly LayerMask GimmickArrow;

			// Token: 0x04019B7C RID: 105340
			[Token(Token = "0x401C1B6")]
			[FieldOffset(Offset = "0x30")]
			public static readonly LayerMask FootStep;

			// Token: 0x04019B7D RID: 105341
			[Token(Token = "0x401C1B7")]
			[FieldOffset(Offset = "0x34")]
			public static readonly LayerMask Water;

			// Token: 0x04019B7E RID: 105342
			[Token(Token = "0x401C1B8")]
			[FieldOffset(Offset = "0x38")]
			public static readonly LayerMask CinemachineCollideAgainst;

			// Token: 0x04019B7F RID: 105343
			[Token(Token = "0x401C1B9")]
			[FieldOffset(Offset = "0x3C")]
			public static readonly LayerMask PutOnItem;

			// Token: 0x04019B80 RID: 105344
			[Token(Token = "0x401C1BA")]
			[FieldOffset(Offset = "0x40")]
			public static readonly LayerMask ThrowWorldStatic;
		}

		// Token: 0x02001237 RID: 4663
		[Token(Token = "0x200159A")]
		public static class Area
		{
			// Token: 0x04019B81 RID: 105345
			[Token(Token = "0x401C1BB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int Walkable;

			// Token: 0x04019B82 RID: 105346
			[Token(Token = "0x401C1BC")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int NotWalkable;

			// Token: 0x04019B83 RID: 105347
			[Token(Token = "0x401C1BD")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int Jump;

			// Token: 0x04019B84 RID: 105348
			[Token(Token = "0x401C1BE")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int NpcField;

			// Token: 0x04019B85 RID: 105349
			[Token(Token = "0x401C1BF")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int BossField;

			// Token: 0x04019B86 RID: 105350
			[Token(Token = "0x401C1C0")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int NpcIndoor;
		}

		// Token: 0x02001238 RID: 4664
		[Token(Token = "0x200159B")]
		public static class AreaMask
		{
			// Token: 0x04019B87 RID: 105351
			[Token(Token = "0x401C1C1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int Walkable;

			// Token: 0x04019B88 RID: 105352
			[Token(Token = "0x401C1C2")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int NotWalkable;

			// Token: 0x04019B89 RID: 105353
			[Token(Token = "0x401C1C3")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int Jump;

			// Token: 0x04019B8A RID: 105354
			[Token(Token = "0x401C1C4")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int NpcField;

			// Token: 0x04019B8B RID: 105355
			[Token(Token = "0x401C1C5")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int BossField;

			// Token: 0x04019B8C RID: 105356
			[Token(Token = "0x401C1C6")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int NpcIndoor;

			// Token: 0x04019B8D RID: 105357
			[Token(Token = "0x401C1C7")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int CharacterArea;
		}

		// Token: 0x02001239 RID: 4665
		[Token(Token = "0x200159C")]
		public static class QueryFilter
		{
			// Token: 0x04019B8E RID: 105358
			[Token(Token = "0x401C1C8")]
			[FieldOffset(Offset = "0x0")]
			public static NavMeshQueryFilter CharacterQueryFilter;
		}
	}
}
