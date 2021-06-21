using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001059 RID: 4185
	[Token(Token = "0x2000AA1")]
	public class FishObjectPool : MonoBehaviour
	{
		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x000240D8 File Offset: 0x000222D8
		[Token(Token = "0x17000A8F")]
		public int Count
		{
			[Token(Token = "0x60057D7")]
			[Address(RVA = "0x2034E50", Offset = "0x2034F51", VA = "0x2034E50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D8")]
		[Address(RVA = "0x2034EA0", Offset = "0x2034FA1", VA = "0x2034EA0")]
		public void SetFishShadow(GameObject fish)
		{
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D9")]
		[Address(RVA = "0x2034EB0", Offset = "0x2034FB1", VA = "0x2034EB0")]
		private void Awake()
		{
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DA")]
		[Address(RVA = "0x2034EC0", Offset = "0x2034FC1", VA = "0x2034EC0")]
		private void Update()
		{
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DB")]
		[Address(RVA = "0x20352D0", Offset = "0x20353D1", VA = "0x20352D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x000240F0 File Offset: 0x000222F0
		[Token(Token = "0x60057DC")]
		[Address(RVA = "0x2035450", Offset = "0x2035551", VA = "0x2035450")]
		public int GetIndex()
		{
			return 0;
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DD")]
		[Address(RVA = "0x2035550", Offset = "0x2035651", VA = "0x2035550")]
		public FishSwim Get(int index)
		{
			return null;
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DE")]
		[Address(RVA = "0x2034DB0", Offset = "0x2034EB1", VA = "0x2034DB0")]
		public void Release(int index)
		{
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0x2034F30", Offset = "0x2035031", VA = "0x2034F30")]
		private void Add()
		{
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x2035670", Offset = "0x2035771", VA = "0x2035670")]
		public FishObjectPool()
		{
		}

		// Token: 0x04017162 RID: 94562
		[Token(Token = "0x4013DC1")]
		private const int DEF_POOL_MAX = 8;

		// Token: 0x04017163 RID: 94563
		[Token(Token = "0x4013DC2")]
		[FieldOffset(Offset = "0x18")]
		private List<FishSwim> Pool;

		// Token: 0x04017164 RID: 94564
		[Token(Token = "0x4013DC3")]
		[FieldOffset(Offset = "0x20")]
		private GameObject FishShadow;
	}
}
