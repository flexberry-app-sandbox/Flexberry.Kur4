import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.kur4.caption'),
          title: i18n.t('forms.application.sitemap.kur4.title'),
          children: [{
            link: 'i-i-s-kur4-контрагенты-l',
            caption: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-контрагенты-l.caption'),
            title: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-контрагенты-l.title'),
            children: null
          }, {
            link: 'i-i-s-kur4-питание-l',
            caption: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-питание-l.caption'),
            title: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-питание-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-kur4-должности-l',
            caption: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-должности-l.caption'),
            title: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-должности-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: 'i-i-s-kur4-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-сотрудники-l.title'),
            icon: 'paperclip',
            children: null
          }, {
            link: 'i-i-s-kur4-документ-заказа-l',
            caption: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-документ-заказа-l.caption'),
            title: i18n.t('forms.application.sitemap.kur4.i-i-s-kur4-документ-заказа-l.title'),
            icon: 'phone',
            children: null
          }]
        }
      ]
    };
  }),
})