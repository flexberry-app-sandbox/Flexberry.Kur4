import { Serializer as РегистрБлюдSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kur4-регистр-блюд';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(РегистрБлюдSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
