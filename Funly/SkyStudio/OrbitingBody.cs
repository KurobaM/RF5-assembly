using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DCE RID: 3534
	[Token(Token = "0x20008FC")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x148B60", Offset = "0x148C61")]
	public class OrbitingBody : MonoBehaviour
	{
		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000913")]
		public Transform positionTransform
		{
			[Token(Token = "0x6004B98")]
			[Address(RVA = "0x23D9930", Offset = "0x23D9A31", VA = "0x23D9930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000914")]
		public RotateBody rotateBody
		{
			[Token(Token = "0x6004B99")]
			[Address(RVA = "0x23D99F0", Offset = "0x23D9AF1", VA = "0x23D99F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B7A RID: 23418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000915")]
		public SpherePoint Point
		{
			[Token(Token = "0x6004B9A")]
			[Address(RVA = "0x23D9B30", Offset = "0x23D9C31", VA = "0x23D9B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B9B")]
			[Address(RVA = "0x23D9B40", Offset = "0x23D9C41", VA = "0x23D9B40")]
			set
			{
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06005B7B RID: 23419 RVA: 0x0001E138 File Offset: 0x0001C338
		[Token(Token = "0x17000916")]
		public Vector3 BodyGlobalDirection
		{
			[Token(Token = "0x6004B9C")]
			[Address(RVA = "0x23D9DA0", Offset = "0x23D9EA1", VA = "0x23D9DA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06005B7C RID: 23420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000917")]
		public Light BodyLight
		{
			[Token(Token = "0x6004B9D")]
			[Address(RVA = "0x23D9DB0", Offset = "0x23D9EB1", VA = "0x23D9DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x23D9EF0", Offset = "0x23D9FF1", VA = "0x23D9EF0")]
		public void ResetOrbit()
		{
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x23D9C90", Offset = "0x23D9D91", VA = "0x23D9C90")]
		public void LayoutOribit()
		{
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x23D9F20", Offset = "0x23DA021", VA = "0x23D9F20")]
		private void OnValidate()
		{
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x23D9F30", Offset = "0x23DA031", VA = "0x23D9F30")]
		public OrbitingBody()
		{
		}

		// Token: 0x0400BB00 RID: 47872
		[Token(Token = "0x4008B85")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_PositionTransform;

		// Token: 0x0400BB01 RID: 47873
		[Token(Token = "0x4008B86")]
		[FieldOffset(Offset = "0x20")]
		private RotateBody m_RotateBody;

		// Token: 0x0400BB02 RID: 47874
		[Token(Token = "0x4008B87")]
		[FieldOffset(Offset = "0x28")]
		private SpherePoint m_SpherePoint;

		// Token: 0x0400BB03 RID: 47875
		[Token(Token = "0x4008B88")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_CachedWorldDirection;

		// Token: 0x0400BB04 RID: 47876
		[Token(Token = "0x4008B89")]
		[FieldOffset(Offset = "0x40")]
		private Light m_BodyLight;
	}
}
