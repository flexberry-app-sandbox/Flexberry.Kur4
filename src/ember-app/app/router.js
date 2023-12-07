import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-kur4-документ-заказа-l');
  this.route('i-i-s-kur4-документ-заказа-e',
  { path: 'i-i-s-kur4-документ-заказа-e/:id' });
  this.route('i-i-s-kur4-документ-заказа-e.new',
  { path: 'i-i-s-kur4-документ-заказа-e/new' });
  this.route('i-i-s-kur4-должности-l');
  this.route('i-i-s-kur4-должности-e',
  { path: 'i-i-s-kur4-должности-e/:id' });
  this.route('i-i-s-kur4-должности-e.new',
  { path: 'i-i-s-kur4-должности-e/new' });
  this.route('i-i-s-kur4-контрагенты-l');
  this.route('i-i-s-kur4-контрагенты-e',
  { path: 'i-i-s-kur4-контрагенты-e/:id' });
  this.route('i-i-s-kur4-контрагенты-e.new',
  { path: 'i-i-s-kur4-контрагенты-e/new' });
  this.route('i-i-s-kur4-питание-l');
  this.route('i-i-s-kur4-питание-e',
  { path: 'i-i-s-kur4-питание-e/:id' });
  this.route('i-i-s-kur4-питание-e.new',
  { path: 'i-i-s-kur4-питание-e/new' });
  this.route('i-i-s-kur4-сотрудники-l');
  this.route('i-i-s-kur4-сотрудники-e',
  { path: 'i-i-s-kur4-сотрудники-e/:id' });
  this.route('i-i-s-kur4-сотрудники-e.new',
  { path: 'i-i-s-kur4-сотрудники-e/new' });
});

export default Router;
