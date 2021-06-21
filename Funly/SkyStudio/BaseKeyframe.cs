using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE2 RID: 3554
	[Token(Token = "0x200090E")]
	[Serializable]
	public class BaseKeyframe : IComparable, IBaseKeyframe
	{
		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091F")]
		public string id
		{
			[Token(Token = "0x6004BEB")]
			[Address(RVA = "0x23D3280", Offset = "0x23D3381", VA = "0x23D3280", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BEC")]
			[Address(RVA = "0x23D3290", Offset = "0x23D3391", VA = "0x23D3290")]
			set
			{
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x0001E378 File Offset: 0x0001C578
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000920")]
		public float time
		{
			[Token(Token = "0x6004BED")]
			[Address(RVA = "0x23D32A0", Offset = "0x23D33A1", VA = "0x23D32A0", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BEE")]
			[Address(RVA = "0x23D32B0", Offset = "0x23D33B1", VA = "0x23D32B0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x0001E390 File Offset: 0x0001C590
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000921")]
		public InterpolationCurve interpolationCurve
		{
			[Token(Token = "0x6004BEF")]
			[Address(RVA = "0x23D32C0", Offset = "0x23D33C1", VA = "0x23D32C0", Slot = "8")]
			get
			{
				return InterpolationCurve.Linear;
			}
			[Token(Token = "0x6004BF0")]
			[Address(RVA = "0x23D32D0", Offset = "0x23D33D1", VA = "0x23D32D0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		// (set) Token: 0x06005BD7 RID: 23511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000922")]
		public InterpolationDirection interpolationDirection
		{
			[Token(Token = "0x6004BF1")]
			[Address(RVA = "0x23D32E0", Offset = "0x23D33E1", VA = "0x23D32E0", Slot = "10")]
			get
			{
				return InterpolationDirection.Auto;
			}
			[Token(Token = "0x6004BF2")]
			[Address(RVA = "0x23D32F0", Offset = "0x23D33F1", VA = "0x23D32F0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0x23D3300", Offset = "0x23D3401", VA = "0x23D3300")]
		public BaseKeyframe(float time)
		{
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x23D33B0", Offset = "0x23D34B1", VA = "0x23D33B0", Slot = "4")]
		public int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x0400BB2B RID: 47915
		[Token(Token = "0x4008BAA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string m_Id;

		// Token: 0x0400BB2C RID: 47916
		[Token(Token = "0x4008BAB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Time;

		// Token: 0x0400BB2D RID: 47917
		[Token(Token = "0x4008BAC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private InterpolationCurve m_InterpolationCurve;

		// Token: 0x0400BB2E RID: 47918
		[Token(Token = "0x4008BAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InterpolationDirection m_InterpolationDirection;
	}
}
