using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XftWeapon
{
	// Token: 0x02000BC8 RID: 3016
	[Token(Token = "0x20007D7")]
	public class XWeaponTrail : MonoBehaviour
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x00018840 File Offset: 0x00016A40
		[Token(Token = "0x170007F9")]
		public float UpdateInterval
		{
			[Token(Token = "0x60040AB")]
			[Address(RVA = "0x1E59B70", Offset = "0x1E59C71", VA = "0x1E59B70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x00018858 File Offset: 0x00016A58
		[Token(Token = "0x170007FA")]
		public Vector3 CurHeadPos
		{
			[Token(Token = "0x60040AC")]
			[Address(RVA = "0x1E59B80", Offset = "0x1E59C81", VA = "0x1E59B80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x00018870 File Offset: 0x00016A70
		[Token(Token = "0x170007FB")]
		public float TrailWidth
		{
			[Token(Token = "0x60040AD")]
			[Address(RVA = "0x1E59C60", Offset = "0x1E59D61", VA = "0x1E59C60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x1E56BC0", Offset = "0x1E56CC1", VA = "0x1E56BC0")]
		public void Init()
		{
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x1E57270", Offset = "0x1E57371", VA = "0x1E57270")]
		public void Activate()
		{
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x1E57220", Offset = "0x1E57321", VA = "0x1E57220")]
		public void Deactivate()
		{
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x1E57540", Offset = "0x1E57641", VA = "0x1E57540")]
		public void StopSmoothly(float fadeTime)
		{
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x1E5A810", Offset = "0x1E5A911", VA = "0x1E5A810")]
		private void OnEnable()
		{
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x1E5A820", Offset = "0x1E5A921", VA = "0x1E5A820")]
		private void OnDisable()
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x1E5A870", Offset = "0x1E5A971", VA = "0x1E5A870")]
		private void Update()
		{
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x1E5ABF0", Offset = "0x1E5ACF1", VA = "0x1E5ABF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x1E5AC20", Offset = "0x1E5AD21", VA = "0x1E5AC20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x1E5AC40", Offset = "0x1E5AD41", VA = "0x1E5AC40")]
		private void Start()
		{
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x1E5AC50", Offset = "0x1E5AD51", VA = "0x1E5AC50")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x1E59FA0", Offset = "0x1E5A0A1", VA = "0x1E59FA0")]
		private void InitSpline()
		{
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x1E5A1F0", Offset = "0x1E5A2F1", VA = "0x1E5A1F0")]
		private void RefreshSpline()
		{
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x1E5A410", Offset = "0x1E5A511", VA = "0x1E5A410")]
		private void UpdateVertex()
		{
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x1E5AE70", Offset = "0x1E5AF71", VA = "0x1E5AE70")]
		private void UpdateIndices()
		{
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x1E5A8F0", Offset = "0x1E5A9F1", VA = "0x1E5A8F0")]
		private void UpdateHeadElem()
		{
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x1E5AB50", Offset = "0x1E5AC51", VA = "0x1E5AB50")]
		private void UpdateFade()
		{
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x1E5A9B0", Offset = "0x1E5AAB1", VA = "0x1E5A9B0")]
		private void RecordCurElem()
		{
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x1E59E30", Offset = "0x1E59F31", VA = "0x1E59E30")]
		private void InitOriginalElements()
		{
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x1E59D70", Offset = "0x1E59E71", VA = "0x1E59D70")]
		private void InitMeshObj()
		{
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x1E5B270", Offset = "0x1E5B371", VA = "0x1E5B270")]
		public XWeaponTrail()
		{
		}

		// Token: 0x0400AEA8 RID: 44712
		[Token(Token = "0x40083C0")]
		[FieldOffset(Offset = "0x0")]
		public static string Version;

		// Token: 0x0400AEA9 RID: 44713
		[Token(Token = "0x40083C1")]
		[FieldOffset(Offset = "0x18")]
		public bool UseWith2D;

		// Token: 0x0400AEAA RID: 44714
		[Token(Token = "0x40083C2")]
		[FieldOffset(Offset = "0x20")]
		public string SortingLayerName;

		// Token: 0x0400AEAB RID: 44715
		[Token(Token = "0x40083C3")]
		[FieldOffset(Offset = "0x28")]
		public int SortingOrder;

		// Token: 0x0400AEAC RID: 44716
		[Token(Token = "0x40083C4")]
		[FieldOffset(Offset = "0x30")]
		public Transform PointStart;

		// Token: 0x0400AEAD RID: 44717
		[Token(Token = "0x40083C5")]
		[FieldOffset(Offset = "0x38")]
		public Transform PointEnd;

		// Token: 0x0400AEAE RID: 44718
		[Token(Token = "0x40083C6")]
		[FieldOffset(Offset = "0x40")]
		public int MaxFrame;

		// Token: 0x0400AEAF RID: 44719
		[Token(Token = "0x40083C7")]
		[FieldOffset(Offset = "0x44")]
		public int Granularity;

		// Token: 0x0400AEB0 RID: 44720
		[Token(Token = "0x40083C8")]
		[FieldOffset(Offset = "0x48")]
		public float Fps;

		// Token: 0x0400AEB1 RID: 44721
		[Token(Token = "0x40083C9")]
		[FieldOffset(Offset = "0x4C")]
		public Color MyColor;

		// Token: 0x0400AEB2 RID: 44722
		[Token(Token = "0x40083CA")]
		[FieldOffset(Offset = "0x60")]
		public Material MyMaterial;

		// Token: 0x0400AEB3 RID: 44723
		[Token(Token = "0x40083CB")]
		[FieldOffset(Offset = "0x68")]
		protected float mTrailWidth;

		// Token: 0x0400AEB4 RID: 44724
		[Token(Token = "0x40083CC")]
		[FieldOffset(Offset = "0x70")]
		protected XWeaponTrail.Element mHeadElem;

		// Token: 0x0400AEB5 RID: 44725
		[Token(Token = "0x40083CD")]
		[FieldOffset(Offset = "0x78")]
		protected List<XWeaponTrail.Element> mSnapshotList;

		// Token: 0x0400AEB6 RID: 44726
		[Token(Token = "0x40083CE")]
		[FieldOffset(Offset = "0x80")]
		protected XWeaponTrail.ElementPool mElemPool;

		// Token: 0x0400AEB7 RID: 44727
		[Token(Token = "0x40083CF")]
		[FieldOffset(Offset = "0x88")]
		protected Spline mSpline;

		// Token: 0x0400AEB8 RID: 44728
		[Token(Token = "0x40083D0")]
		[FieldOffset(Offset = "0x90")]
		protected float mFadeT;

		// Token: 0x0400AEB9 RID: 44729
		[Token(Token = "0x40083D1")]
		[FieldOffset(Offset = "0x94")]
		protected bool mIsFading;

		// Token: 0x0400AEBA RID: 44730
		[Token(Token = "0x40083D2")]
		[FieldOffset(Offset = "0x98")]
		protected float mFadeTime;

		// Token: 0x0400AEBB RID: 44731
		[Token(Token = "0x40083D3")]
		[FieldOffset(Offset = "0x9C")]
		protected float mElapsedTime;

		// Token: 0x0400AEBC RID: 44732
		[Token(Token = "0x40083D4")]
		[FieldOffset(Offset = "0xA0")]
		protected float mFadeElapsedime;

		// Token: 0x0400AEBD RID: 44733
		[Token(Token = "0x40083D5")]
		[FieldOffset(Offset = "0xA8")]
		protected GameObject mMeshObj;

		// Token: 0x0400AEBE RID: 44734
		[Token(Token = "0x40083D6")]
		[FieldOffset(Offset = "0xB0")]
		protected VertexPool mVertexPool;

		// Token: 0x0400AEBF RID: 44735
		[Token(Token = "0x40083D7")]
		[FieldOffset(Offset = "0xB8")]
		protected VertexPool.VertexSegment mVertexSegment;

		// Token: 0x0400AEC0 RID: 44736
		[Token(Token = "0x40083D8")]
		[FieldOffset(Offset = "0xC0")]
		protected bool mInited;

		// Token: 0x0400AEC1 RID: 44737
		[Token(Token = "0x40083D9")]
		[FieldOffset(Offset = "0xC1")]
		protected bool mActivated;

		// Token: 0x02000BC9 RID: 3017
		[Token(Token = "0x2001371")]
		public class Element
		{
			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06004D2F RID: 19759 RVA: 0x00018888 File Offset: 0x00016A88
			[Token(Token = "0x17000DC7")]
			public Vector3 Pos
			{
				[Token(Token = "0x600774D")]
				[Address(RVA = "0x1E5A140", Offset = "0x1E5A241", VA = "0x1E5A140")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06004D30 RID: 19760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600774E")]
			[Address(RVA = "0x1E5B200", Offset = "0x1E5B301", VA = "0x1E5B200")]
			public Element(Vector3 start, Vector3 end)
			{
			}

			// Token: 0x06004D31 RID: 19761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600774F")]
			[Address(RVA = "0x1E5B370", Offset = "0x1E5B471", VA = "0x1E5B370")]
			public Element()
			{
			}

			// Token: 0x0400AEC2 RID: 44738
			[Token(Token = "0x401B741")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 PointStart;

			// Token: 0x0400AEC3 RID: 44739
			[Token(Token = "0x401B742")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 PointEnd;
		}

		// Token: 0x02000BCA RID: 3018
		[Token(Token = "0x2001372")]
		public class ElementPool
		{
			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x06004D32 RID: 19762 RVA: 0x000188A0 File Offset: 0x00016AA0
			// (set) Token: 0x06004D33 RID: 19763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DC8")]
			public int CountAll
			{
				[Token(Token = "0x6007750")]
				[Address(RVA = "0x1E5B3E0", Offset = "0x1E5B4E1", VA = "0x1E5B3E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45A0", Offset = "0x1B46A1")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007751")]
				[Address(RVA = "0x1E5B3F0", Offset = "0x1E5B4F1", VA = "0x1E5B3F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45B0", Offset = "0x1B46B1")]
				private set
				{
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x06004D34 RID: 19764 RVA: 0x000188B8 File Offset: 0x00016AB8
			[Token(Token = "0x17000DC9")]
			public int CountActive
			{
				[Token(Token = "0x6007752")]
				[Address(RVA = "0x1E5B400", Offset = "0x1E5B501", VA = "0x1E5B400")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06004D35 RID: 19765 RVA: 0x000188D0 File Offset: 0x00016AD0
			[Token(Token = "0x17000DCA")]
			public int CountInactive
			{
				[Token(Token = "0x6007753")]
				[Address(RVA = "0x1E5B460", Offset = "0x1E5B561", VA = "0x1E5B460")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004D36 RID: 19766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007754")]
			[Address(RVA = "0x1E59C70", Offset = "0x1E59D71", VA = "0x1E59C70")]
			public ElementPool(int preCount)
			{
			}

			// Token: 0x06004D37 RID: 19767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007755")]
			[Address(RVA = "0x1E5B090", Offset = "0x1E5B191", VA = "0x1E5B090")]
			public XWeaponTrail.Element Get()
			{
				return null;
			}

			// Token: 0x06004D38 RID: 19768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007756")]
			[Address(RVA = "0x1E5B130", Offset = "0x1E5B231", VA = "0x1E5B130")]
			public void Release(XWeaponTrail.Element element)
			{
			}

			// Token: 0x0400AEC4 RID: 44740
			[Token(Token = "0x401B743")]
			[FieldOffset(Offset = "0x10")]
			private readonly Stack<XWeaponTrail.Element> _stack;

			// Token: 0x0400AEC5 RID: 44741
			[Token(Token = "0x401B744")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195800", Offset = "0x195901")]
			private int <CountAll>k__BackingField;
		}
	}
}
