using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using RF5SHOP;
using UnityEngine;

namespace Field
{
	// Token: 0x02001111 RID: 4369
	[Token(Token = "0x2000AFF")]
	public class TextureChangeByFlagPolice : TextureChangeByFlag
	{
		// Token: 0x06006E85 RID: 28293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x20310C0", Offset = "0x20311C1", VA = "0x20310C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x20311E0", Offset = "0x20312E1", VA = "0x20311E0", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x2031240", Offset = "0x2031341", VA = "0x2031240", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AED20", Offset = "0x1AEE21")]
		public override IEnumerator Load()
		{
			return null;
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x20312F0", Offset = "0x20313F1", VA = "0x20312F0")]
		public TextureChangeByFlagPolice()
		{
		}

		// Token: 0x0401810E RID: 98574
		[Token(Token = "0x4014BD5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BuilderId[] CurtainBuilderIds;

		// Token: 0x0401810F RID: 98575
		[Token(Token = "0x4014BD6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BuilderId[] WallBuilderIds;

		// Token: 0x04018110 RID: 98576
		[Token(Token = "0x4014BD7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BuilderId[] FloorBuilderIds;

		// Token: 0x04018111 RID: 98577
		[Token(Token = "0x4014BD8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] CurtainLoaderIds;

		// Token: 0x04018112 RID: 98578
		[Token(Token = "0x4014BD9")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] WallLoaderIds;

		// Token: 0x04018113 RID: 98579
		[Token(Token = "0x4014BDA")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] FloorLoaderIds;

		// Token: 0x04018114 RID: 98580
		[Token(Token = "0x4014BDB")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int[] FloorNormalLoaderIds;

		// Token: 0x04018115 RID: 98581
		[Token(Token = "0x4014BDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Renderer[] CurtainChangeRenderers;

		// Token: 0x04018116 RID: 98582
		[Token(Token = "0x4014BDD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Renderer[] WallChangeRenderers;

		// Token: 0x04018117 RID: 98583
		[Token(Token = "0x4014BDE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Renderer[] FloorChangeRenderers;

		// Token: 0x04018118 RID: 98584
		[Token(Token = "0x4014BDF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Material CurtainChangeMaterial;

		// Token: 0x04018119 RID: 98585
		[Token(Token = "0x4014BE0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Material WallChangeMaterial;

		// Token: 0x0401811A RID: 98586
		[Token(Token = "0x4014BE1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Material FloorChangeMaterial;

		// Token: 0x0401811B RID: 98587
		[Token(Token = "0x4014BE2")]
		[FieldOffset(Offset = "0x68")]
		private int LoadCurtainId;

		// Token: 0x0401811C RID: 98588
		[Token(Token = "0x4014BE3")]
		[FieldOffset(Offset = "0x6C")]
		private int LoadWallId;

		// Token: 0x0401811D RID: 98589
		[Token(Token = "0x4014BE4")]
		[FieldOffset(Offset = "0x70")]
		private int LoadFloorId;

		// Token: 0x0401811E RID: 98590
		[Token(Token = "0x4014BE5")]
		[FieldOffset(Offset = "0x74")]
		private int LoadFloorNormalId;

		// Token: 0x0401811F RID: 98591
		[Token(Token = "0x4014BE6")]
		[FieldOffset(Offset = "0x78")]
		private int BumpMapPropertyId;

		// Token: 0x04018120 RID: 98592
		[Token(Token = "0x4014BE7")]
		[FieldOffset(Offset = "0x7C")]
		private bool IsLoad;

		// Token: 0x02001112 RID: 4370
		[Token(Token = "0x200157E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A170", Offset = "0x15A271")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06006E8A RID: 28298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8B")]
			[Address(RVA = "0x20314F0", Offset = "0x20315F1", VA = "0x20314F0")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06006E8B RID: 28299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8C")]
			[Address(RVA = "0x2031500", Offset = "0x2031601", VA = "0x2031500")]
			internal void <Load>b__0(AssetHandle<Texture> handle)
			{
			}

			// Token: 0x06006E8C RID: 28300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8D")]
			[Address(RVA = "0x20315B0", Offset = "0x20316B1", VA = "0x20315B0")]
			internal void <Load>b__1(AssetHandle<Texture> handle)
			{
			}

			// Token: 0x06006E8D RID: 28301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8E")]
			[Address(RVA = "0x2031660", Offset = "0x2031761", VA = "0x2031660")]
			internal void <Load>b__2(AssetHandle<Texture> handle)
			{
			}

			// Token: 0x06006E8E RID: 28302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8F")]
			[Address(RVA = "0x2031710", Offset = "0x2031811", VA = "0x2031710")]
			internal void <Load>b__3(AssetHandle<Texture> handle)
			{
			}

			// Token: 0x04018121 RID: 98593
			[Token(Token = "0x401C145")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x04018122 RID: 98594
			[Token(Token = "0x401C146")]
			[FieldOffset(Offset = "0x18")]
			public TextureChangeByFlagPolice <>4__this;
		}

		// Token: 0x02001113 RID: 4371
		[Token(Token = "0x200157F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A180", Offset = "0x15A281")]
		private sealed class <Load>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006E8F RID: 28303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D90")]
			[Address(RVA = "0x20312C0", Offset = "0x20313C1", VA = "0x20312C0")]
			[DebuggerHidden]
			public <Load>d__21(int <>1__state)
			{
			}

			// Token: 0x06006E90 RID: 28304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D91")]
			[Address(RVA = "0x20317C0", Offset = "0x20318C1", VA = "0x20317C0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E91 RID: 28305 RVA: 0x00025FE0 File Offset: 0x000241E0
			[Token(Token = "0x6007D92")]
			[Address(RVA = "0x20317D0", Offset = "0x20318D1", VA = "0x20317D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x06006E92 RID: 28306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECB")]
			private object Current
			{
				[Token(Token = "0x6007D93")]
				[Address(RVA = "0x2031D30", Offset = "0x2031E31", VA = "0x2031D30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E93 RID: 28307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D94")]
			[Address(RVA = "0x2031D40", Offset = "0x2031E41", VA = "0x2031D40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x06006E94 RID: 28308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECC")]
			private object Current
			{
				[Token(Token = "0x6007D95")]
				[Address(RVA = "0x2031DA0", Offset = "0x2031EA1", VA = "0x2031DA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018123 RID: 98595
			[Token(Token = "0x401C147")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018124 RID: 98596
			[Token(Token = "0x401C148")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018125 RID: 98597
			[Token(Token = "0x401C149")]
			[FieldOffset(Offset = "0x20")]
			public TextureChangeByFlagPolice <>4__this;

			// Token: 0x04018126 RID: 98598
			[Token(Token = "0x401C14A")]
			[FieldOffset(Offset = "0x28")]
			private TextureChangeByFlagPolice.<>c__DisplayClass21_0 <>8__1;
		}
	}
}
