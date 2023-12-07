import {
  defineNamespace,
  defineProjections,
  Model as РегистрБлюдMixin
} from '../mixins/regenerated/models/i-i-s-kur4-регистр-блюд';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(РегистрБлюдMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
