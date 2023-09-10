using UnityEngine;
using UnityEngine.UI;

public class ManagerAttack : MonoBehaviour
{
    [SerializeField] private Button _buttonAttackShockerBandit;
    [SerializeField] private Button _buttonAttackSliverKnifeBandit;
    [SerializeField] private Button _buttonAttackShockerVampire;
    [SerializeField] private Button _buttonAttackSliverKnifeVampire;

    private IVisitorAttack _attackBandit;
    private IVisitorAttack _attackVampire;
    private IWeapon _shocker;
    private IWeapon _sliverKnife;

    private void Start()
    {
        InitialUnit();
        InitialWeapon();

        ListenerEvents();
    }

    private void InitialWeapon()
    {
        _shocker = new Shocker();
        _sliverKnife = new SliverKnife();
    }

    private void InitialUnit()
    {
        _attackBandit = new Bandit();
        _attackVampire = new Vampire();
    }
    
    private void ListenerEvents()
    {
        _buttonAttackShockerBandit.onClick.AddListener(() => _shocker.Attack(_attackBandit));
        _buttonAttackSliverKnifeBandit.onClick.AddListener(() => _sliverKnife.Attack(_attackBandit));
        _buttonAttackShockerVampire.onClick.AddListener(() => _shocker.Attack(_attackVampire));
        _buttonAttackSliverKnifeVampire.onClick.AddListener(() => _sliverKnife.Attack(_attackVampire));
    }
}
