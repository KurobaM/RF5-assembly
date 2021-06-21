using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001114 RID: 4372
	[Token(Token = "0x2000B00")]
	public class VisibleChangeByFlag : ObjectLoader
	{
		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06006E95 RID: 28309 RVA: 0x00025FF8 File Offset: 0x000241F8
		[Token(Token = "0x17000AFC")]
		public bool IsInit
		{
			[Token(Token = "0x6005BAE")]
			[Address(RVA = "0x2031DB0", Offset = "0x2031EB1", VA = "0x2031DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x00026010 File Offset: 0x00024210
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x2031DC0", Offset = "0x2031EC1", VA = "0x2031DC0")]
		public new bool NeedsLoad()
		{
			return default(bool);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x2031DD0", Offset = "0x2031ED1", VA = "0x2031DD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x2031F30", Offset = "0x2032031", VA = "0x2031F30")]
		private void Awake()
		{
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0x2032140", Offset = "0x2032241", VA = "0x2032140", Slot = "5")]
		public virtual void UpdateObjectVisible()
		{
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x2032200", Offset = "0x2032301", VA = "0x2032200")]
		protected void SetTargetActive(bool setValue)
		{
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x20324D0", Offset = "0x20325D1", VA = "0x20324D0")]
		public VisibleChangeByFlag()
		{
		}

		// Token: 0x04018127 RID: 98599
		[Token(Token = "0x4014BE8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public GameFlagData GameFlagData;

		// Token: 0x04018128 RID: 98600
		[Token(Token = "0x4014BE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _IsFlagVisivle;

		// Token: 0x04018129 RID: 98601
		[Token(Token = "0x4014BEA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameObject[] VisibleChangeObject;

		// Token: 0x0401812A RID: 98602
		[Token(Token = "0x4014BEB")]
		[FieldOffset(Offset = "0x40")]
		public int[] LoadIds;

		// Token: 0x0401812B RID: 98603
		[Token(Token = "0x4014BEC")]
		[FieldOffset(Offset = "0x48")]
		public List<int> LoadDataList;

		// Token: 0x0401812C RID: 98604
		[Token(Token = "0x4014BED")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<int, GameObject> LoadObjectDict;

		// Token: 0x0401812D RID: 98605
		[Token(Token = "0x4014BEE")]
		[FieldOffset(Offset = "0x58")]
		protected bool _IsInit;

		// Token: 0x02001115 RID: 4373
		[Token(Token = "0x2001580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A190", Offset = "0x15A291")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06006E9C RID: 28316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D96")]
			[Address(RVA = "0x20324B0", Offset = "0x20325B1", VA = "0x20324B0")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0401812E RID: 98606
			[Token(Token = "0x401C14B")]
			[FieldOffset(Offset = "0x10")]
			public VisibleChangeByFlag <>4__this;

			// Token: 0x0401812F RID: 98607
			[Token(Token = "0x401C14C")]
			[FieldOffset(Offset = "0x18")]
			public bool setValue;
		}

		// Token: 0x02001116 RID: 4374
		[Token(Token = "0x2001581")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1A0", Offset = "0x15A2A1")]
		private sealed class <>c__DisplayClass13_1
		{
			// Token: 0x06006E9D RID: 28317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D97")]
			[Address(RVA = "0x20324C0", Offset = "0x20325C1", VA = "0x20324C0")]
			public <>c__DisplayClass13_1()
			{
			}

			// Token: 0x06006E9E RID: 28318 RVA: 0x00026028 File Offset: 0x00024228
			[Token(Token = "0x6007D98")]
			[Address(RVA = "0x2032590", Offset = "0x2032691", VA = "0x2032590")]
			internal bool <SetTargetActive>b__0(int dataId)
			{
				return default(bool);
			}

			// Token: 0x06006E9F RID: 28319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D99")]
			[Address(RVA = "0x20325A0", Offset = "0x20326A1", VA = "0x20325A0")]
			internal void <SetTargetActive>b__1(GameObject loadData)
			{
			}

			// Token: 0x04018130 RID: 98608
			[Token(Token = "0x401C14D")]
			[FieldOffset(Offset = "0x10")]
			public int loadId;

			// Token: 0x04018131 RID: 98609
			[Token(Token = "0x401C14E")]
			[FieldOffset(Offset = "0x18")]
			public VisibleChangeByFlag.<>c__DisplayClass13_0 CS$<>8__locals1;
		}
	}
}
