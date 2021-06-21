using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB8 RID: 3256
	[Token(Token = "0x200085A")]
	[Attribute(Name = "RequireComponent", RVA = "0x1479A0", Offset = "0x147AA1")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		// Token: 0x060053BF RID: 21439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D3")]
		[Address(RVA = "0x29AF780", Offset = "0x29AF881", VA = "0x29AF780")]
		private void Start()
		{
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x29AF800", Offset = "0x29AF901", VA = "0x29AF800")]
		private void LateUpdate()
		{
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x0001BC18 File Offset: 0x00019E18
		[Token(Token = "0x17000898")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60045D5")]
			[Address(RVA = "0x29AFB60", Offset = "0x29AFC61", VA = "0x29AFB60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x0001BC30 File Offset: 0x00019E30
		[Token(Token = "0x17000899")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60045D6")]
			[Address(RVA = "0x29AFC00", Offset = "0x29AFD01", VA = "0x29AFC00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x29AFCA0", Offset = "0x29AFDA1", VA = "0x29AFCA0")]
		public CharacterController3rdPerson()
		{
		}

		// Token: 0x0400B2A8 RID: 45736
		[Token(Token = "0x400861F")]
		[FieldOffset(Offset = "0x18")]
		public CameraController cam;

		// Token: 0x0400B2A9 RID: 45737
		[Token(Token = "0x4008620")]
		[FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;
	}
}
