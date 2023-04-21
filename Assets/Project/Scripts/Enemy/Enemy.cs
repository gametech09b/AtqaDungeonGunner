using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace DungeonGunner
{
    [DisallowMultipleComponent]
    #region Requirement Components
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(PolygonCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(SortingGroup))]
    [RequireComponent(typeof(SpriteRenderer))]
    #endregion
    public class Enemy : MonoBehaviour
    {
        private CircleCollider2D _circleCollider2D;
        private PolygonCollider2D _polygonCollider2D;
        private SpriteRenderer[] _spriteRendererArray;
        
        [HideInInspector] public EnemyDetailSO enemyDetail;



        private void Awake() {
            _circleCollider2D = GetComponent<CircleCollider2D>();
            _polygonCollider2D = GetComponent<PolygonCollider2D>();
            _spriteRendererArray = GetComponentsInChildren<SpriteRenderer>();
        }
    }
}