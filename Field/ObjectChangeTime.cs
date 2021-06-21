using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001105 RID: 4357
	[Token(Token = "0x2000AF8")]
	public class ObjectChangeTime : MonoBehaviour
	{
		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E3B RID: 28219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF6")]
		public TimeParamTable TimeParamTable
		{
			[Token(Token = "0x6005B79")]
			[Address(RVA = "0x202DEA0", Offset = "0x202DFA1", VA = "0x202DEA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B7A")]
			[Address(RVA = "0x202DEB0", Offset = "0x202DFB1", VA = "0x202DEB0")]
			set
			{
			}
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0x202DEC0", Offset = "0x202DFC1", VA = "0x202DEC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0x202DFB0", Offset = "0x202E0B1", VA = "0x202DFB0")]
		private void Start()
		{
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0x202E060", Offset = "0x202E161", VA = "0x202E060", Slot = "4")]
		public virtual void UpdateObjectActive(bool value)
		{
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0x202E1B0", Offset = "0x202E2B1", VA = "0x202E1B0")]
		public ObjectChangeTime()
		{
		}

		// Token: 0x040180E6 RID: 98534
		[Token(Token = "0x4014BC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TimeParamTable _TimeParamTable;

		// Token: 0x040180E7 RID: 98535
		[Token(Token = "0x4014BC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public GameObject[] GameObjects;

		// Token: 0x040180E8 RID: 98536
		[Token(Token = "0x4014BC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Renderer[] Renderers;

		// Token: 0x040180E9 RID: 98537
		[Token(Token = "0x4014BC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ParticleSystem[] ParticleSystems;
	}
}
