using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DCF RID: 3535
	[Token(Token = "0x20008FD")]
	public class RotateBody : MonoBehaviour
	{
		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x0001E150 File Offset: 0x0001C350
		// (set) Token: 0x06005B82 RID: 23426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000918")]
		public float SpinSpeed
		{
			[Token(Token = "0x6004BA2")]
			[Address(RVA = "0x23DCA00", Offset = "0x23DCB01", VA = "0x23DCA00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x23DCA10", Offset = "0x23DCB11", VA = "0x23DCA10")]
			set
			{
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06005B83 RID: 23427 RVA: 0x0001E168 File Offset: 0x0001C368
		// (set) Token: 0x06005B84 RID: 23428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000919")]
		public bool AllowSpinning
		{
			[Token(Token = "0x6004BA4")]
			[Address(RVA = "0x23DCB60", Offset = "0x23DCC61", VA = "0x23DCB60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BA5")]
			[Address(RVA = "0x23DCB70", Offset = "0x23DCC71", VA = "0x23DCB70")]
			set
			{
			}
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x23DCA20", Offset = "0x23DCB21", VA = "0x23DCA20")]
		public void UpdateOrbitBodyRotation()
		{
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x23DCB80", Offset = "0x23DCC81", VA = "0x23DCB80")]
		public RotateBody()
		{
		}

		// Token: 0x0400BB05 RID: 47877
		[Token(Token = "0x4008B8A")]
		[FieldOffset(Offset = "0x18")]
		private float m_SpinSpeed;

		// Token: 0x0400BB06 RID: 47878
		[Token(Token = "0x4008B8B")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_AllowSpinning;
	}
}
