using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x0200105A RID: 4186
	[Token(Token = "0x2000AA2")]
	public class FishSwim : MonoBehaviour
	{
		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600696F RID: 26991 RVA: 0x00024108 File Offset: 0x00022308
		[Token(Token = "0x17000A90")]
		public FishSwim.State GatState
		{
			[Token(Token = "0x60057E1")]
			[Address(RVA = "0x2035770", Offset = "0x2035871", VA = "0x2035770")]
			get
			{
				return FishSwim.State.NONE;
			}
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x2035780", Offset = "0x2035881", VA = "0x2035780")]
		public void SetState(FishSwim.State state)
		{
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x00024120 File Offset: 0x00022320
		[Token(Token = "0x17000A91")]
		public Vector3 BoxSize
		{
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0x2035790", Offset = "0x2035891", VA = "0x2035790")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x20355D0", Offset = "0x20356D1", VA = "0x20355D0")]
		public void SetBoxSize(Vector3 size)
		{
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x20357A0", Offset = "0x20358A1", VA = "0x20357A0")]
		public void SetTarget(Vector3 target)
		{
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06006974 RID: 26996 RVA: 0x00024138 File Offset: 0x00022338
		// (set) Token: 0x06006975 RID: 26997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A92")]
		public int UniqueId
		{
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0x20357B0", Offset = "0x20358B1", VA = "0x20357B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3D0", Offset = "0x1AD4D1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057E7")]
			[Address(RVA = "0x20357C0", Offset = "0x20358C1", VA = "0x20357C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3E0", Offset = "0x1AD4E1")]
			private set
			{
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x00024150 File Offset: 0x00022350
		// (set) Token: 0x06006977 RID: 26999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A93")]
		public bool IsSingleSpawn
		{
			[Token(Token = "0x60057E8")]
			[Address(RVA = "0x20357D0", Offset = "0x20358D1", VA = "0x20357D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD3F0", Offset = "0x1AD4F1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60057E9")]
			[Address(RVA = "0x20357E0", Offset = "0x20358E1", VA = "0x20357E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD400", Offset = "0x1AD501")]
			private set
			{
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06006978 RID: 27000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006979 RID: 27001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A94")]
		public FishAnimation fishAnimation
		{
			[Token(Token = "0x60057EA")]
			[Address(RVA = "0x20357F0", Offset = "0x20358F1", VA = "0x20357F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD410", Offset = "0x1AD511")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057EB")]
			[Address(RVA = "0x2035800", Offset = "0x2035901", VA = "0x2035800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD420", Offset = "0x1AD521")]
			private set
			{
			}
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0x2035810", Offset = "0x2035911", VA = "0x2035810")]
		public void FadeIn(float time = 1f)
		{
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0x20359C0", Offset = "0x2035AC1", VA = "0x20359C0")]
		public void FadeOut(float time = 1f)
		{
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x2035920", Offset = "0x2035A21", VA = "0x2035920")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD430", Offset = "0x1AD531")]
		private IEnumerator Fade(float start, float end, float fade_time)
		{
			return null;
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x2035AC0", Offset = "0x2035BC1", VA = "0x2035AC0")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x2035B40", Offset = "0x2035C41", VA = "0x2035B40")]
		public void SetMaterial(Material material)
		{
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F1")]
		[Address(RVA = "0x2035BF0", Offset = "0x2035CF1", VA = "0x2035BF0")]
		private void Awake()
		{
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x2035DE0", Offset = "0x2035EE1", VA = "0x2035DE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x2034C10", Offset = "0x2034D11", VA = "0x2034C10")]
		public void Release()
		{
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x2036040", Offset = "0x2036141", VA = "0x2036040")]
		private void Update()
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x2037230", Offset = "0x2037331", VA = "0x2037230")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD4A0", Offset = "0x1AD5A1")]
		private IEnumerator BiteCoroutine()
		{
			return null;
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x20372B0", Offset = "0x20373B1", VA = "0x20372B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD510", Offset = "0x1AD611")]
		private IEnumerator HitCoroutine()
		{
			return null;
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0x2037460", Offset = "0x2037561", VA = "0x2037460")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD580", Offset = "0x1AD681")]
		private IEnumerator HattenCoroutine()
		{
			return null;
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x2037510", Offset = "0x2037611", VA = "0x2037510")]
		public void Hatten()
		{
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F9")]
		[Address(RVA = "0x20375B0", Offset = "0x20376B1", VA = "0x20375B0")]
		public void Escape()
		{
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0x2037950", Offset = "0x2037A51", VA = "0x2037950")]
		public void SetMove()
		{
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x20379C0", Offset = "0x2037AC1", VA = "0x20379C0")]
		public void Spawn()
		{
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00024168 File Offset: 0x00022368
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x2037AA0", Offset = "0x2037BA1", VA = "0x2037AA0")]
		private float BiteTime(float default_time)
		{
			return 0f;
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x2037AE0", Offset = "0x2037BE1", VA = "0x2037AE0")]
		public void Surprise()
		{
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x2037B80", Offset = "0x2037C81", VA = "0x2037B80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD5F0", Offset = "0x1AD6F1")]
		private IEnumerator SurpriseCoroutine()
		{
			return null;
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0x20378B0", Offset = "0x20379B1", VA = "0x20378B0")]
		private void PlayManpu(EmotionType emotionType)
		{
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x2037C30", Offset = "0x2037D31", VA = "0x2037C30")]
		public FishSwim()
		{
		}

		// Token: 0x04017165 RID: 94565
		[Token(Token = "0x4013DC4")]
		[FieldOffset(Offset = "0x18")]
		public string PointName;

		// Token: 0x04017166 RID: 94566
		[Token(Token = "0x4013DC5")]
		[FieldOffset(Offset = "0x20")]
		public ItemID FishId;

		// Token: 0x04017167 RID: 94567
		[Token(Token = "0x4013DC6")]
		[FieldOffset(Offset = "0x24")]
		public int Size;

		// Token: 0x04017168 RID: 94568
		[Token(Token = "0x4013DC7")]
		[FieldOffset(Offset = "0x28")]
		public int DispSize;

		// Token: 0x04017169 RID: 94569
		[Token(Token = "0x4013DC8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HideInInspector", RVA = "0x180730", Offset = "0x180831")]
		public int IsDay;

		// Token: 0x0401716A RID: 94570
		[Token(Token = "0x4013DC9")]
		[FieldOffset(Offset = "0x30")]
		public float ChangeInterval;

		// Token: 0x0401716B RID: 94571
		[Token(Token = "0x4013DCA")]
		[FieldOffset(Offset = "0x34")]
		public bool Use;

		// Token: 0x0401716C RID: 94572
		[Token(Token = "0x4013DCB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FishSwim.State state_;

		// Token: 0x0401716D RID: 94573
		[Token(Token = "0x4013DCC")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 box_size_;

		// Token: 0x0401716E RID: 94574
		[Token(Token = "0x4013DCD")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 FishingBoxPos;

		// Token: 0x0401716F RID: 94575
		[Token(Token = "0x4013DCE")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "HideInInspector", RVA = "0x180750", Offset = "0x180851")]
		public Quaternion FishingBoxRot;

		// Token: 0x04017170 RID: 94576
		[Token(Token = "0x4013DCF")]
		[FieldOffset(Offset = "0x64")]
		private float move_speed_;

		// Token: 0x04017171 RID: 94577
		[Token(Token = "0x4013DD0")]
		[FieldOffset(Offset = "0x68")]
		private float move_speed2_;

		// Token: 0x04017172 RID: 94578
		[Token(Token = "0x4013DD1")]
		[FieldOffset(Offset = "0x6C")]
		private float rotate_speed_;

		// Token: 0x04017173 RID: 94579
		[Token(Token = "0x4013DD2")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion startRotation;

		// Token: 0x04017174 RID: 94580
		[Token(Token = "0x4013DD3")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion targetRotation;

		// Token: 0x04017175 RID: 94581
		[Token(Token = "0x4013DD4")]
		[FieldOffset(Offset = "0x90")]
		private float rotate_time_;

		// Token: 0x04017176 RID: 94582
		[Token(Token = "0x4013DD5")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 target_;

		// Token: 0x04017177 RID: 94583
		[Token(Token = "0x4013DD6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int biteCount;

		// Token: 0x04017178 RID: 94584
		[Token(Token = "0x4013DD7")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float biteWaitTime;

		// Token: 0x04017179 RID: 94585
		[Token(Token = "0x4013DD8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float PunchTime;

		// Token: 0x0401717A RID: 94586
		[Token(Token = "0x4013DD9")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Ease PunchEase;

		// Token: 0x0401717B RID: 94587
		[Token(Token = "0x4013DDA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float PunchTime2;

		// Token: 0x0401717C RID: 94588
		[Token(Token = "0x4013DDB")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Ease PunchEase2;

		// Token: 0x0401717D RID: 94589
		[Token(Token = "0x4013DDC")]
		[FieldOffset(Offset = "0xB8")]
		private float[] hit_wait_time_;

		// Token: 0x0401717E RID: 94590
		[Token(Token = "0x4013DDD")]
		[FieldOffset(Offset = "0xC0")]
		private float time_;

		// Token: 0x0401717F RID: 94591
		[Token(Token = "0x4013DDE")]
		[FieldOffset(Offset = "0xC4")]
		private float dist_;

		// Token: 0x04017180 RID: 94592
		[Token(Token = "0x4013DDF")]
		[FieldOffset(Offset = "0xC8")]
		private Coroutine coroutine_;

		// Token: 0x04017181 RID: 94593
		[Token(Token = "0x4013DE0")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1807C0", Offset = "0x1808C1")]
		private int <UniqueId>k__BackingField;

		// Token: 0x04017182 RID: 94594
		[Token(Token = "0x4013DE1")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1807D0", Offset = "0x1808D1")]
		private bool <IsSingleSpawn>k__BackingField;

		// Token: 0x04017183 RID: 94595
		[Token(Token = "0x4013DE2")]
		[FieldOffset(Offset = "0xD8")]
		public float InactiveTime;

		// Token: 0x04017184 RID: 94596
		[Token(Token = "0x4013DE3")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1807E0", Offset = "0x1808E1")]
		private FishAnimation <fishAnimation>k__BackingField;

		// Token: 0x04017185 RID: 94597
		[Token(Token = "0x4013DE4")]
		[FieldOffset(Offset = "0xE8")]
		private Tweener _tween;

		// Token: 0x04017186 RID: 94598
		[Token(Token = "0x4013DE5")]
		[FieldOffset(Offset = "0xF0")]
		private int StartTime;

		// Token: 0x04017187 RID: 94599
		[Token(Token = "0x4013DE6")]
		[FieldOffset(Offset = "0xF8")]
		private EmotionController emotionController;

		// Token: 0x04017188 RID: 94600
		[Token(Token = "0x4013DE7")]
		[FieldOffset(Offset = "0x100")]
		private Renderer _renderer;

		// Token: 0x04017189 RID: 94601
		[Token(Token = "0x4013DE8")]
		[FieldOffset(Offset = "0x108")]
		private MaterialPropertyBlock materialPropertyBlock;

		// Token: 0x0401718A RID: 94602
		[Token(Token = "0x4013DE9")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine fadeCoroutine;

		// Token: 0x0401718B RID: 94603
		[Token(Token = "0x4013DEA")]
		[FieldOffset(Offset = "0x118")]
		private SkinnedMeshRenderer SkinnedMeshRenderer;

		// Token: 0x0401718C RID: 94604
		[Token(Token = "0x4013DEB")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 startPos;

		// Token: 0x0401718D RID: 94605
		[Token(Token = "0x4013DEC")]
		[FieldOffset(Offset = "0x12C")]
		private Vector3 targetPos;

		// Token: 0x0200105B RID: 4187
		[Token(Token = "0x2001524")]
		public enum State
		{
			// Token: 0x0401718F RID: 94607
			[Token(Token = "0x401BFAE")]
			NONE,
			// Token: 0x04017190 RID: 94608
			[Token(Token = "0x401BFAF")]
			MOVE,
			// Token: 0x04017191 RID: 94609
			[Token(Token = "0x401BFB0")]
			ROTATE,
			// Token: 0x04017192 RID: 94610
			[Token(Token = "0x401BFB1")]
			APPROACH,
			// Token: 0x04017193 RID: 94611
			[Token(Token = "0x401BFB2")]
			BITE_WAIT,
			// Token: 0x04017194 RID: 94612
			[Token(Token = "0x401BFB3")]
			BITE_START,
			// Token: 0x04017195 RID: 94613
			[Token(Token = "0x401BFB4")]
			BITE,
			// Token: 0x04017196 RID: 94614
			[Token(Token = "0x401BFB5")]
			HIT,
			// Token: 0x04017197 RID: 94615
			[Token(Token = "0x401BFB6")]
			ESCAPE,
			// Token: 0x04017198 RID: 94616
			[Token(Token = "0x401BFB7")]
			GET,
			// Token: 0x04017199 RID: 94617
			[Token(Token = "0x401BFB8")]
			SURPRISE,
			// Token: 0x0401719A RID: 94618
			[Token(Token = "0x401BFB9")]
			LEAVE
		}

		// Token: 0x0200105C RID: 4188
		[Token(Token = "0x2001525")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C60", Offset = "0x159D61")]
		private sealed class <Fade>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600698F RID: 27023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C3D")]
			[Address(RVA = "0x2035A90", Offset = "0x2035B91", VA = "0x2035A90")]
			[DebuggerHidden]
			public <Fade>d__57(int <>1__state)
			{
			}

			// Token: 0x06006990 RID: 27024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C3E")]
			[Address(RVA = "0x20382E0", Offset = "0x20383E1", VA = "0x20382E0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006991 RID: 27025 RVA: 0x00024180 File Offset: 0x00022380
			[Token(Token = "0x6007C3F")]
			[Address(RVA = "0x20382F0", Offset = "0x20383F1", VA = "0x20382F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06006992 RID: 27026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E83")]
			private object Current
			{
				[Token(Token = "0x6007C40")]
				[Address(RVA = "0x2038480", Offset = "0x2038581", VA = "0x2038480", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006993 RID: 27027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C41")]
			[Address(RVA = "0x2038490", Offset = "0x2038591", VA = "0x2038490", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x06006994 RID: 27028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E84")]
			private object Current
			{
				[Token(Token = "0x6007C42")]
				[Address(RVA = "0x20384F0", Offset = "0x20385F1", VA = "0x20384F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401719B RID: 94619
			[Token(Token = "0x401BFBA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401719C RID: 94620
			[Token(Token = "0x401BFBB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401719D RID: 94621
			[Token(Token = "0x401BFBC")]
			[FieldOffset(Offset = "0x20")]
			public float fade_time;

			// Token: 0x0401719E RID: 94622
			[Token(Token = "0x401BFBD")]
			[FieldOffset(Offset = "0x28")]
			public FishSwim <>4__this;

			// Token: 0x0401719F RID: 94623
			[Token(Token = "0x401BFBE")]
			[FieldOffset(Offset = "0x30")]
			public float end;

			// Token: 0x040171A0 RID: 94624
			[Token(Token = "0x401BFBF")]
			[FieldOffset(Offset = "0x34")]
			public float start;

			// Token: 0x040171A1 RID: 94625
			[Token(Token = "0x401BFC0")]
			[FieldOffset(Offset = "0x38")]
			private float <time>5__2;
		}

		// Token: 0x0200105D RID: 4189
		[Token(Token = "0x2001526")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C70", Offset = "0x159D71")]
		private sealed class <BiteCoroutine>d__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006995 RID: 27029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C43")]
			[Address(RVA = "0x2037400", Offset = "0x2037501", VA = "0x2037400")]
			[DebuggerHidden]
			public <BiteCoroutine>d__67(int <>1__state)
			{
			}

			// Token: 0x06006996 RID: 27030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C44")]
			[Address(RVA = "0x2037DF0", Offset = "0x2037EF1", VA = "0x2037DF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006997 RID: 27031 RVA: 0x00024198 File Offset: 0x00022398
			[Token(Token = "0x6007C45")]
			[Address(RVA = "0x2037E00", Offset = "0x2037F01", VA = "0x2037E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x06006998 RID: 27032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E85")]
			private object Current
			{
				[Token(Token = "0x6007C46")]
				[Address(RVA = "0x2038260", Offset = "0x2038361", VA = "0x2038260", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006999 RID: 27033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C47")]
			[Address(RVA = "0x2038270", Offset = "0x2038371", VA = "0x2038270", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x0600699A RID: 27034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E86")]
			private object Current
			{
				[Token(Token = "0x6007C48")]
				[Address(RVA = "0x20382D0", Offset = "0x20383D1", VA = "0x20382D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040171A2 RID: 94626
			[Token(Token = "0x401BFC1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040171A3 RID: 94627
			[Token(Token = "0x401BFC2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040171A4 RID: 94628
			[Token(Token = "0x401BFC3")]
			[FieldOffset(Offset = "0x20")]
			public FishSwim <>4__this;
		}

		// Token: 0x0200105E RID: 4190
		[Token(Token = "0x2001527")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C80", Offset = "0x159D81")]
		private sealed class <HitCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600699B RID: 27035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C49")]
			[Address(RVA = "0x2037430", Offset = "0x2037531", VA = "0x2037430")]
			[DebuggerHidden]
			public <HitCoroutine>d__68(int <>1__state)
			{
			}

			// Token: 0x0600699C RID: 27036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C4A")]
			[Address(RVA = "0x20386F0", Offset = "0x20387F1", VA = "0x20386F0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600699D RID: 27037 RVA: 0x000241B0 File Offset: 0x000223B0
			[Token(Token = "0x6007C4B")]
			[Address(RVA = "0x2038700", Offset = "0x2038801", VA = "0x2038700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x0600699E RID: 27038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E87")]
			private object Current
			{
				[Token(Token = "0x6007C4C")]
				[Address(RVA = "0x2038DE0", Offset = "0x2038EE1", VA = "0x2038DE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600699F RID: 27039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C4D")]
			[Address(RVA = "0x2038DF0", Offset = "0x2038EF1", VA = "0x2038DF0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x060069A0 RID: 27040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E88")]
			private object Current
			{
				[Token(Token = "0x6007C4E")]
				[Address(RVA = "0x2038E50", Offset = "0x2038F51", VA = "0x2038E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040171A5 RID: 94629
			[Token(Token = "0x401BFC4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040171A6 RID: 94630
			[Token(Token = "0x401BFC5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040171A7 RID: 94631
			[Token(Token = "0x401BFC6")]
			[FieldOffset(Offset = "0x20")]
			public FishSwim <>4__this;
		}

		// Token: 0x0200105F RID: 4191
		[Token(Token = "0x2001528")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C90", Offset = "0x159D91")]
		private sealed class <HattenCoroutine>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060069A1 RID: 27041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C4F")]
			[Address(RVA = "0x20374E0", Offset = "0x20375E1", VA = "0x20374E0")]
			[DebuggerHidden]
			public <HattenCoroutine>d__69(int <>1__state)
			{
			}

			// Token: 0x060069A2 RID: 27042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C50")]
			[Address(RVA = "0x2038500", Offset = "0x2038601", VA = "0x2038500", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060069A3 RID: 27043 RVA: 0x000241C8 File Offset: 0x000223C8
			[Token(Token = "0x6007C51")]
			[Address(RVA = "0x2038510", Offset = "0x2038611", VA = "0x2038510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x060069A4 RID: 27044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E89")]
			private object Current
			{
				[Token(Token = "0x6007C52")]
				[Address(RVA = "0x2038670", Offset = "0x2038771", VA = "0x2038670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060069A5 RID: 27045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C53")]
			[Address(RVA = "0x2038680", Offset = "0x2038781", VA = "0x2038680", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x060069A6 RID: 27046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8A")]
			private object Current
			{
				[Token(Token = "0x6007C54")]
				[Address(RVA = "0x20386E0", Offset = "0x20387E1", VA = "0x20386E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040171A8 RID: 94632
			[Token(Token = "0x401BFC7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040171A9 RID: 94633
			[Token(Token = "0x401BFC8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040171AA RID: 94634
			[Token(Token = "0x401BFC9")]
			[FieldOffset(Offset = "0x20")]
			public FishSwim <>4__this;
		}

		// Token: 0x02001060 RID: 4192
		[Token(Token = "0x2001529")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CA0", Offset = "0x159DA1")]
		private sealed class <SurpriseCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060069A7 RID: 27047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C55")]
			[Address(RVA = "0x2037C00", Offset = "0x2037D01", VA = "0x2037C00")]
			[DebuggerHidden]
			public <SurpriseCoroutine>d__76(int <>1__state)
			{
			}

			// Token: 0x060069A8 RID: 27048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C56")]
			[Address(RVA = "0x2038E60", Offset = "0x2038F61", VA = "0x2038E60", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060069A9 RID: 27049 RVA: 0x000241E0 File Offset: 0x000223E0
			[Token(Token = "0x6007C57")]
			[Address(RVA = "0x2038E70", Offset = "0x2038F71", VA = "0x2038E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x060069AA RID: 27050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8B")]
			private object Current
			{
				[Token(Token = "0x6007C58")]
				[Address(RVA = "0x20392F0", Offset = "0x20393F1", VA = "0x20392F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060069AB RID: 27051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C59")]
			[Address(RVA = "0x2039300", Offset = "0x2039401", VA = "0x2039300", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x060069AC RID: 27052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8C")]
			private object Current
			{
				[Token(Token = "0x6007C5A")]
				[Address(RVA = "0x2039360", Offset = "0x2039461", VA = "0x2039360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040171AB RID: 94635
			[Token(Token = "0x401BFCA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040171AC RID: 94636
			[Token(Token = "0x401BFCB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040171AD RID: 94637
			[Token(Token = "0x401BFCC")]
			[FieldOffset(Offset = "0x20")]
			public FishSwim <>4__this;

			// Token: 0x040171AE RID: 94638
			[Token(Token = "0x401BFCD")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 <sa>5__2;

			// Token: 0x040171AF RID: 94639
			[Token(Token = "0x401BFCE")]
			[FieldOffset(Offset = "0x34")]
			private float <speed>5__3;
		}
	}
}
