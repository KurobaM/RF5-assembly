using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000DA6 RID: 3494
	[Token(Token = "0x20008E9")]
	public class VRIKLODController : MonoBehaviour
	{
		// Token: 0x06005A53 RID: 23123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x27D51F0", Offset = "0x27D52F1", VA = "0x27D51F0")]
		private void Start()
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A99")]
		[Address(RVA = "0x27D5250", Offset = "0x27D5351", VA = "0x27D5250")]
		private void Update()
		{
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x27D5290", Offset = "0x27D5391", VA = "0x27D5290")]
		private int GetLODLevel()
		{
			return 0;
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x27D5420", Offset = "0x27D5521", VA = "0x27D5420")]
		public VRIKLODController()
		{
		}

		// Token: 0x0400B9B8 RID: 47544
		[Token(Token = "0x4008AAC")]
		[FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		// Token: 0x0400B9B9 RID: 47545
		[Token(Token = "0x4008AAD")]
		[FieldOffset(Offset = "0x20")]
		public float LODDistance;

		// Token: 0x0400B9BA RID: 47546
		[Token(Token = "0x4008AAE")]
		[FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		// Token: 0x0400B9BB RID: 47547
		[Token(Token = "0x4008AAF")]
		[FieldOffset(Offset = "0x28")]
		private VRIK ik;
	}
}
